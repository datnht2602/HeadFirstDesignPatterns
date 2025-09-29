using System;
using System.Collections.Generic;

namespace ObserverPattern.WeatherObservable;

public class WeatherDataTracker : IObservable<WeatherDataReport>
{
    private readonly List<IObserver<WeatherDataReport>> _observers = [];
    public IDisposable Subscribe(IObserver<WeatherDataReport> observer)
    {
        if (!_observers.Contains(observer))
        {
            _observers.Add(observer);
        }
        return new Unsubscriber(_observers, observer);
    }
    
    private class Unsubscriber : IDisposable
    {
        private readonly List<IObserver<WeatherDataReport>> _observers;
        private readonly IObserver<WeatherDataReport> _observer;

        public Unsubscriber(List<IObserver<WeatherDataReport>> observers, IObserver<WeatherDataReport> observer)
        {
            _observers = observers;
            _observer = observer;
        }
        public void Dispose()
        {
            if(_observer != null && _observers.Contains(_observer))
            {
                _observers.Remove(_observer);
            }
        }
    }

    public void UpdateData(WeatherDataReport report)
    {
        foreach (var observer in _observers)
        {
            observer.OnNext(report);
        }
    }

    public void EndTransmission()
    {
        foreach (var observer in _observers)
        {
            if (_observers.Contains(observer))
            {
                observer.OnCompleted();
            }
        }
        _observers.Clear();
    }
}


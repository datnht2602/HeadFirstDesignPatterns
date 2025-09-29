using System;
using ObserverPattern.Concrete;
using ObserverPattern.Interface;

namespace ObserverPattern.WeatherObservable;

public class ForecastDisplay : IObserver<WeatherDataReport> , IDisplayElement
{
    private float _currentPressure = 29.92f;
    
    private float _lastPressure;
    
    private IDisposable _subscription;

    public ForecastDisplay(IObservable<WeatherDataReport> observable)
    {
        _subscription = observable.Subscribe(this);
    }
    
    public void OnCompleted()
    {
        _subscription.Dispose();
    }

    public void OnError(Exception error)
    {
        throw new NotImplementedException();
    }

    public void OnNext(WeatherDataReport value)
    {
        _lastPressure = _currentPressure;
        _currentPressure = value.Pressure;
        Display();
    }

    public void Display()
    {
        Console.WriteLine("Forecast: ");
        if (_currentPressure > _lastPressure) {
            Console.WriteLine("Improving weather on the way!");
        } else if (_currentPressure == _lastPressure) {
            Console.WriteLine("More of the same");
        } else if (_currentPressure < _lastPressure) {
            Console.WriteLine("Watch out for cooler, rainy weather");
        }
    }
}
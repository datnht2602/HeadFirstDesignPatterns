using System.Collections.Generic;
using ObserverPattern.Interface;

namespace ObserverPattern.Concrete;

public class WeatherData : ISubject
{
    private readonly List<IObserver> _observers = [];
    private float _temperature;
    private float _humidity;
    private float _pressure;
    public void RegisterObserver(IObserver o)
    {
        _observers.Add(o);
    }

    public void RemoveObserver(IObserver o)
    {
        _observers.Remove(o);
    }

    public void NotifyObserver()
    {
        _observers.ForEach(observer => observer.Update(_temperature, _humidity, _pressure));
    }

    public void MeasurementsChanged()
    {
        NotifyObserver();
    }

    public void SetMeasurements(float temperature, float humidity, float pressure)
    {
        _temperature = temperature;
        _humidity = humidity;
        _pressure = pressure;
        MeasurementsChanged();
    }
}
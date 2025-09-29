using System;
using ObserverPattern.Interface;

namespace ObserverPattern.WeatherObservable;

public class CurrentConditionDisplay : IObserver<WeatherDataReport> , IDisplayElement
{
    private readonly IDisposable _observable;

    private float _temperature;
    private float _humidity;
    
    public CurrentConditionDisplay(IObservable<WeatherDataReport> observable)
    {
        _observable = observable.Subscribe(this);
    }
    public void OnCompleted()
    {
        _observable.Dispose();
    }

    public void OnError(Exception error)
    {
        throw new NotImplementedException();
    }

    public void OnNext(WeatherDataReport value)
    {
        _humidity = value.Humidity;
        _temperature = value.Temp;
        Display();
    }

    public void Display()
    {
        Console.WriteLine("Current condition: " + _temperature + "F degrees and " + _humidity + "% humidity");
    }
}
using System;
using ObserverPattern.Interface;

namespace ObserverPattern.Concrete;

public class CurrentConditionDisplay : IObserver, IDisplayElement
{
    private float _temperature;
    private float _humidity;

    public CurrentConditionDisplay(ISubject observable)
    {
        observable.RegisterObserver(this);
    }
    public void Update(float temp, float humidity, float pressure)
    {
        _temperature = temp;
        _humidity = humidity;
        Display();
    }

    public void Display()
    {
        Console.WriteLine("Current condition: " + _temperature + "F degrees and " + _humidity + "% humidity");
    }
}
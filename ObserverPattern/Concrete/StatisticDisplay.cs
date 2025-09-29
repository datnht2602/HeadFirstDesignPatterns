using System;
using ObserverPattern.Interface;

namespace ObserverPattern.Concrete;

public class StatisticDisplay : IObserver, IDisplayElement
{
    private float _maxTemp = 0.0f;
    
    private float _minTemp = 200;
    
    private float _tempSum = 0.0f;

    private int _numReading;
    
    private ISubject _subject;

    public StatisticDisplay(ISubject subject)
    {
        _subject = subject;
    }
    public void Update(float temp, float humidity, float pressure)
    {
        _tempSum += temp;
        _numReading++; 
        if (temp > _maxTemp)
        {
            _maxTemp = temp;
        }

        if (temp < _minTemp)
        {
            _minTemp = temp;
        }
        Display();
    }

    public void Display()
    {
        Console.WriteLine("Avg/Max/Min temperature = " + (_tempSum / _numReading)
                                                        + "/" + _maxTemp + "/" + _minTemp);
    }
}
using ObserverPattern.Interface;

namespace ObserverPattern.Contract;

public class WeatherData : Subject
{
    private readonly List<Observer> _observers = [];
    private float _temperature;
    private float _humidity;
    private float _pressure;
    public void registerObserver(Observer o)
    {
        _observers.Add(o);
    }

    public void removeObserver(Observer o)
    {
        _observers.Remove(o);
    }

    public void notifyObserver()
    {
        _observers.ForEach(observer => observer.Update(_temperature, _humidity, _pressure));
    }

    public void MeasurementsChanged()
    {
        notifyObserver();
    }

    public void SetMeasurements(float temperature, float humidity, float pressure)
    {
        _temperature = temperature;
        _humidity = humidity;
        _pressure = pressure;
        MeasurementsChanged();
    }
}
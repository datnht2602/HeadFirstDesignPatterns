using ObserverPattern.Interface;

namespace ObserverPattern.Contract;

public class CurrentConditionDisplay : Observer, DisplayElement
{
    private float _temperarture;
    private float _humidity;
    private WeatherData _weatherData;

    public CurrentConditionDisplay(WeatherData weatherData)
    {
        _weatherData = weatherData;
        weatherData.registerObserver(this);
    }
    public void Update(float temp, float humidity, float pressure)
    {
        _temperarture = temp;
        _humidity = humidity;
        Display();
    }

    public void Display()
    {
        Console.WriteLine("Current condition: " + _temperarture + "F degrees and " + _humidity + "% humidity");
    }
}
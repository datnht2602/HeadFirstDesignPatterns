namespace ObserverPattern.Interface;

public interface Observer
{
    void Update(float temp, float humidity, float pressure);
}
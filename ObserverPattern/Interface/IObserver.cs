namespace ObserverPattern.Interface;

public interface IObserver
{
    void Update(float temp, float humidity, float pressure);
}
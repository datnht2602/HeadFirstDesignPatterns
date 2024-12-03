namespace ObserverPattern.Interface;

public interface Subject
{
    void registerObserver(Observer o);
    void removeObserver(Observer o);
    void notifyObserver();
}
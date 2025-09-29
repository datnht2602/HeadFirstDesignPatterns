namespace SingletonFactory;

public class ChocolateBoiler
{
    private bool empty;
    private bool boiled;
    private static ChocolateBoiler chocolateBoiler;

    private ChocolateBoiler()
    {
        empty = true;
        boiled = false;
    }

    public static ChocolateBoiler GetInstance()
    {
        if (chocolateBoiler is null)
        {
            chocolateBoiler = new();
        }

        return chocolateBoiler;
    }

    public void Fill()
    {
        if (isEmpty())
        {
            empty = false;
            boiled = false;
        }
    }

    public void Drain()
    {
        if (!isEmpty() && isBoiled())
        {
            empty = true;
        }
    }

    public void Boil()
    {
        if (!isEmpty() && !isBoiled())
        {
            boiled = true;
        }
    }

    public bool isEmpty()
    {
        return empty;
    }

    public bool isBoiled()
    {
        return boiled;
    }
}
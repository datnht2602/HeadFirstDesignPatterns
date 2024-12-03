using DecoratorPattern.BeverageInterface;

namespace DecoratorPattern.Beverages;

public class Espresso : Beverage
{
    public Espresso()
    {
       Description = "Espresso";
    }

    public override double Cost() => 1.99;
}
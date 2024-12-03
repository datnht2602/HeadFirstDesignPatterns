using DecoratorPattern.BeverageInterface;

namespace DecoratorPattern.Beverages;

public class DarkRoast : Beverage
{
    public DarkRoast()
    {
        Description = "Dark Roast";
    }

    public override double Cost() => .99;
}
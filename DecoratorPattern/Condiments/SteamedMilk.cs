using DecoratorPattern.BeverageInterface;

namespace DecoratorPattern.Condiments;

public class SteamedMilk : CondimentDecorator
{
    public SteamedMilk(Beverage beverage)
    {
        _beverage = beverage;
    }

    public override string GetDescription()
    {
        return _beverage.GetDescription() + ", Steamed Milk";
    }

    public override double Cost() => _beverage.Cost() +  .10;
}
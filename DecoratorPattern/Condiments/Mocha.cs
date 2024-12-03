using DecoratorPattern.BeverageInterface;

namespace DecoratorPattern.Condiments;

public class Mocha : CondimentDecorator
{
    public Mocha(Beverage beverage)
    {
        _beverage = beverage;
    }

    public override string GetDescription()
    {
        return _beverage.GetDescription() + ", Mocha";
    } 

    public override double Cost() => _beverage.Cost() + .20;
}
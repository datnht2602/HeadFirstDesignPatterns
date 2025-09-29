using System;
using StrategyPattern.Concrete.FlyBehavior;
using StrategyPattern.Concrete.QuackBehavior;

namespace StrategyPattern.Animal;

public class RubberDuck : Duck
{
    public RubberDuck()
    {
        SetFlyBehavior(new FlyNoWay());
        SetQuackBehavior(new Squeak());
    }
    public override void Display()
    {
        Console.WriteLine("I'm a rubber duck");
    }
}
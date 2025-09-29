using System;
using StrategyPattern.Concrete.FlyBehavior;
using StrategyPattern.Concrete.QuackBehavior;

namespace StrategyPattern.Animal;

public class MallardDuck : Duck
{
    public MallardDuck()
    {
        SetFlyBehavior(new FlyWithWings());
        SetQuackBehavior(new SimpleQuack());
    }
    public override void Display()
    {
        Console.WriteLine("I'm a real Mallard duck");
    }
}
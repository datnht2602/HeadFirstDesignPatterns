using System;
using StrategyPattern.Concrete.FlyBehavior;
using StrategyPattern.Concrete.QuackBehavior;

namespace StrategyPattern.Animal;

public class DecoyDuck : Duck
{
    public DecoyDuck()
    {
        SetFlyBehavior(new FlyNoWay());
        SetQuackBehavior(new MuteQuack());
    }
    public override void Display()
    {
        Console.WriteLine("I'm a Duck Decoy");
    }
}
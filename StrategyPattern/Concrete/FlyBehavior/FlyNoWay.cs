using System;
using StrategyPattern.Interface;

namespace StrategyPattern.Concrete.FlyBehavior;

public class FlyNoWay : IFlyBehavior
{
    public void Fly()
    {
        Console.WriteLine("I can't fly");
    }
}
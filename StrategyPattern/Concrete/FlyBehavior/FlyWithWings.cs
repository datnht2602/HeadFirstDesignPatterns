using System;
using StrategyPattern.Interface;

namespace StrategyPattern.Concrete.FlyBehavior;

public class FlyWithWings : IFlyBehavior
{
    public void Fly()
    {
        Console.WriteLine("I'm flying");
    }
}
using System;
using StrategyPattern.Interface;

namespace StrategyPattern.Concrete.FlyBehavior;

public class FlyRocketPowered : IFlyBehavior
{
    public void Fly()
    {
        Console.WriteLine("I'm flying with a rocket");
    }
}
using System;
using StrategyPattern.Interface;

namespace StrategyPattern.Concrete.QuackBehavior;

public class Squeak : IQuackBehavior
{
    public void Quack()
    {
        Console.WriteLine("Squeak");
    }
}
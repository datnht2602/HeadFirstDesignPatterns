using System;
using StrategyPattern.Interface;

namespace StrategyPattern.Concrete.QuackBehavior;

public class SimpleQuack : IQuackBehavior
{
    public void Quack()
    {
        Console.WriteLine("Quack");
    }
}
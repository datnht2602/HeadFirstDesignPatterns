using System;
using StrategyPattern.Interface;

namespace StrategyPattern.Concrete.QuackBehavior;

public class MuteQuack : IQuackBehavior
{
    public void Quack()
    {
        Console.WriteLine("<< Silence >>");
    }
}
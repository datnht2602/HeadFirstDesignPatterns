using System;
using StrategyPattern.Interface;

namespace StrategyPattern.Animal;

public abstract class Duck
{
    private IFlyBehavior _flyBehavior;
    
    private IQuackBehavior _quackBehavior;

    public void SetFlyBehavior(IFlyBehavior flyBehavior)
    {
        _flyBehavior = flyBehavior;
    }

    public void SetQuackBehavior(IQuackBehavior quackBehavior)
    {
        _quackBehavior = quackBehavior;
    }

    public void Fly()
    {
        _flyBehavior.Fly();
    }

    public void Quack()
    {
        _quackBehavior.Quack();
    }

    public void Swim()
    {
        Console.WriteLine("All ducks float, even decoys!");
    }
    public abstract void Display();
}
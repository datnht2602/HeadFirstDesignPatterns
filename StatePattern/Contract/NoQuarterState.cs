using System;
using StatePattern.Interface;

namespace StatePattern.Contract;

public class NoQuarterState(GumballMachine gumballMachine) : StateInterface
{
    public void InsertQuarter()
    {
        Console.WriteLine("You inserted a quarter");
        gumballMachine.SetState(gumballMachine.GetHasQuarterState());
    }

    public void EjectQuarter()
    {
        Console.WriteLine("You haven't inserted a quarter");
    }

    public void TurnCrank()
    {
        Console.WriteLine("You turned, but there's no quarter");
    }

    public void Dispense()
    {
        Console.WriteLine("You need to pay first");
    }
}
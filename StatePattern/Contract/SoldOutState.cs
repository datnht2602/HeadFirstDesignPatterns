using System;
using StatePattern.Interface;

namespace StatePattern.Contract;

public class SoldOutState(GumballMachine gumballMachine) : StateInterface
{
    public void InsertQuarter()
    {
        Console.WriteLine("You can't insert a quarter, the machine is sold out");
    }

    public void EjectQuarter()
    {
        Console.WriteLine("You can't eject, you haven't inserted a quarter yet");
    }

    public void TurnCrank()
    {
        Console.WriteLine("You turned, but there are no gumballs");
    }

    public void Dispense()
    {
        Console.WriteLine("No gumball dispensed");
    }
}
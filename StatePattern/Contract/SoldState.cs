using System;
using StatePattern.Interface;

namespace StatePattern.Contract;

public class SoldState(GumballMachine gumballMachine) : StateInterface
{
    public void InsertQuarter()
    {
        Console.WriteLine("Please wait, we're already giving you a gumball");
    }

    public void EjectQuarter()
    {
        Console.WriteLine("Sorry, you already turned the crank");
    }

    public void TurnCrank()
    {
        Console.WriteLine("Turning twice doesn't get you another gumball!");
    }

    public void Dispense()
    {
        gumballMachine.ReleaseBall();
        if (gumballMachine.GetCount() > 0)
        {
            gumballMachine.SetState(gumballMachine.GetNoQuarterState());
        }
        else
        {
            Console.WriteLine("Oops, out of gumballs");
            gumballMachine.SetState(gumballMachine.GetSoldOutState());
        }
    }
}
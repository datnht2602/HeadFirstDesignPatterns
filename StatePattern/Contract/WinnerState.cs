using System;
using StatePattern.Interface;

namespace StatePattern.Contract;

public class WinnerState(GumballMachine gumballMachine) : StateInterface
{
    public void InsertQuarter()
    {
        Console.WriteLine("Please wait, we're already giving you a Gumball");
    }

    public void EjectQuarter()
    {
        Console.WriteLine("Please wait, we're already giving you a Gumball");
    }

    public void TurnCrank()
    {
        Console.WriteLine("Turning again doesn't get you another gumball!");
    }

    public void Dispense()
    {
        gumballMachine.ReleaseBall();
        if (gumballMachine.GetCount() == 0)
        {
            gumballMachine.SetState(gumballMachine.GetSoldOutState());
        }
        else
        {
            gumballMachine.ReleaseBall();
            Console.WriteLine("YOU'RE A WINNER! You got two gumballs for your quarter");
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
}
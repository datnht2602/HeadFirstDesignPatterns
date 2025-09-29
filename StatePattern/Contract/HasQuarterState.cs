using System;
using StatePattern.Interface;

namespace StatePattern.Contract;

public class HasQuarterState(GumballMachine gumballMachine) : StateInterface
{
    private Random _randomWinner = new Random();
    public void InsertQuarter()
    {
        Console.WriteLine("You can't insert another quarter");
    }

    public void EjectQuarter()
    {
        Console.WriteLine("Quarter returned");
        gumballMachine.SetState(gumballMachine.GetNoQuarterState());
    }

    public void TurnCrank()
    {
        Console.WriteLine("You turned...");
        long winner = _randomWinner.NextInt64(10);
        if (winner == 0 && gumballMachine.GetCount() > 1)
        {
            gumballMachine.SetState(gumballMachine.GetWinnerState());
        }
        else
        {
            gumballMachine.SetState(gumballMachine.GetSoldState());

        }
    }

    public void Dispense()
    {
        Console.WriteLine("No gumball dispensed");
    }
}
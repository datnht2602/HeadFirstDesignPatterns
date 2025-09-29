using System.Text;
using StatePattern.Contract;
using StatePattern.Interface;

namespace StatePattern;

public class GumballMachine
{
    StateInterface soldOutState;
    StateInterface noQuarterState;
    StateInterface hasQuarterState;
    StateInterface soldState;
    StateInterface winnerState;
    
    StateInterface state;
    private int count = 0;

    public GumballMachine(int numberGumballs)
    {
        soldOutState = new SoldOutState(this);
        noQuarterState = new NoQuarterState(this);
        hasQuarterState = new HasQuarterState(this);
        soldState = new SoldState(this);
        winnerState = new WinnerState(this);
        
        this.count = numberGumballs;
        state = numberGumballs > 0 ? noQuarterState : soldOutState;
    }

    public void InsertQuarter()
    {
        state.InsertQuarter();
    }

    public void EjectQuarter()
    {
        state.EjectQuarter();
    }

    public void TurnCrank()
    {
        state.TurnCrank();
        state.Dispense();
    }

    public void SetState(StateInterface state)
    {
        this.state = state;
    }

    public StateInterface GetHasQuarterState()
    {
        return hasQuarterState;
    }
    public StateInterface GetNoQuarterState()
    {
        return noQuarterState;
    }
    public StateInterface GetSoldOutState()
    {
        return soldOutState;
    }
    public StateInterface GetSoldState()
    {
        return soldState;
    }
    
    public StateInterface GetWinnerState()
    {
        return winnerState;
    }
    
    public int GetCount() {
        return count;
    }

    public void ReleaseBall()
    {
        Console.WriteLine("A gumball comes rolling out the slot...");
        if (count > 0)
        {
            count -= 1;
        }
    }
    
    public override string ToString() {
        StringBuilder result = new();
        result.Append("\nMighty Gumball, Inc.");
        result.Append("\nJava-enabled Standing Gumball Model #2004");
        result.Append("\nInventory: " + count + " gumball");
        if (count != 1) {
            result.Append('s');
        }
        result.Append('\n');
        result.Append("Machine is " + state + "\n");
        return result.ToString();
    }
}
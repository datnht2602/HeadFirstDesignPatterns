using System;
using System.Collections.Generic;

namespace FactoryPattern.Factory;

public abstract class Pizza
{
    private string name;
    private string dough;
    private string sauce;
    private List<string> toppings = [];

    public void Prepare()
    {
        Console.WriteLine("Preparing " + name);
        Console.WriteLine("Tossing dough...");
        Console.WriteLine("Adding sauce...");
        Console.WriteLine("Adding toppings: ");
        toppings.ForEach(topping => Console.WriteLine(" "+ topping));
    }

    public void Bake()
    {
        Console.WriteLine("Bake for 25 minutes at 350");
    }

    public void Cut()
    {
        Console.WriteLine("Cutting the pizza into diagonal slices");
    }

    public void Box()
    {
        Console.WriteLine("Place pizza in official PizzaStore box");
    }

    public string GetName()
    {
        return name;
    }
}
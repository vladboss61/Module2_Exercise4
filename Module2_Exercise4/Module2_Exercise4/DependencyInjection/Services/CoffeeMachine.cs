using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2_Exercise4.DependencyInjection.Services;



public class CoffeeMachine : INotificationService
{
    public void SendNotification()
    {
        Console.WriteLine("Prepare coffeee.");
    }

    public virtual void PrepareCoffee()
    {

    }
}

public class LateMachine : CoffeeMachine
{
    public override void PrepareCoffee()
    {
        base.PrepareCoffee();
        Console.WriteLine("add milk");
    }
}

// Broken Liskov principal.
public class TeaMachine : CoffeeMachine
{
    public override void PrepareCoffee()
    {
        Console.WriteLine("Prepare tea.");
    }
}

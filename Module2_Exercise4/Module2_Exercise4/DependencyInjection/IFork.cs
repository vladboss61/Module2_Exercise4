using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2_Exercise4.DependencyInjection;

public interface IFork
{
    public void Take(Food food);
}

public class LongFork : IFork
{
    public void Take(Food food)
    {
        Console.WriteLine($"Take food by long FORK. {food.Name}.");
    }
}

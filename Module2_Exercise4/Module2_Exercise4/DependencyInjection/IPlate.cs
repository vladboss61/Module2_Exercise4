using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2_Exercise4.DependencyInjection;

internal interface IPlate
{
    public void MakeUtensils();
}

internal class Plate : IPlate
{
    public IFork Fork { get; }

    public IKnife Knife { get; }

    public Plate(IFork fork, IKnife knife)
    {
        Fork = fork;
        Knife = knife;
    }

    public void MakeUtensils()
    {
        var food = new Food { Name = "Spaghetti" };

        Knife.Cut(food);

        Fork.Take(food);
    }
}


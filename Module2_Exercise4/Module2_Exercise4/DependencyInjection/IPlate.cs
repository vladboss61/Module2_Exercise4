namespace Module2_Exercise4.DependencyInjection;

internal interface IPlate
{
    public void MakeFood();
}

internal class Plate : IPlate
{
    public IFork Fork { get; }

    public IKnife Knife1 { get; }

    public IKnife Knife2 { get; }

    public Plate(IFork fork, IKnife knife1, IKnife knife2)
    {
        Fork = fork;
        Knife1 = knife1;
        Knife2 = knife2;
    }

    public void MakeFood()
    {
        var food = new Food { Name = "Spaghetti" };

        Knife1.Cut(food);
        Fork.Take(food);
    }
}



namespace Module2_Exercise4.DependencyInjection;

public interface IKnife
{
    public void Cut(Food food);
}

public sealed class DishKnife : IKnife
{
    public void Cut(Food food)
    {
        Console.WriteLine($"Cut by Dish Knife. {food.Name}");
    }
}

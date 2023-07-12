
using System;
using System.IO;

namespace Module2_Exercise4.DependencyInjection;


public interface ISharpenable
{
    public void Sharpen();
}

public interface IKnife
{
    public void Cut(Food food);
}

public interface IBladable
{
    public string Type { get; set; }
}

public class Blade : IBladable
{
    public string Type { get; set; }
}

public class FileService
{
    private readonly StreamReader _file;

    public FileService(string path)
    {
        _file = File.OpenText(path);
    }
}

public sealed class DishKnife : IKnife, ISharpenable
{
    private readonly IBladable _blade;

    public DishKnife(IBladable bladable)
    {
        Console.WriteLine($"DishKnife::{Guid.NewGuid()}");
        _blade = bladable;
    }

    public void Cut(Food food)
    {
        Console.WriteLine($"Cut by Dish Knife. {food.Name}");
    }

    public void Sharpen()
    {
        Console.WriteLine("I can sharpen by special device (rock).");
    }
}

public sealed class SingeSharpenKnife : IKnife
{
    public void Cut(Food food)
    {
        Console.WriteLine("Fast cut food.");
    }
}

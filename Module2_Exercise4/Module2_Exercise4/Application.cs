using Module2_Exercise4.DependencyInjection;

namespace Module2_Exercise4;

internal sealed class Application
{
    private readonly IPlate _plate;

    public Application(IPlate plate)
    {
        _plate = plate;
    }

    public void Run()
    {
        _plate.MakeFood();
    }
}

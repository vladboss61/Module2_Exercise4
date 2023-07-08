using Module2_Exercise4.DependencyInjection;

namespace Module2_Exercise4;

internal class Program
{
    static void Main(string[] args)
    {
        IFork fork = new LongFork();
        IKnife knife = new DishKnife();
        IPlate plate = new Plate(fork, knife);
        var application = new Application(plate);

        application.Run();
    }
}

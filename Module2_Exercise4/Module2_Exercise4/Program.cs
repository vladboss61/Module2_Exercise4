using Microsoft.Extensions.DependencyInjection;
using Module2_Exercise4.DependencyInjection;
using Module2_Exercise4.DependencyInjection.Services;

namespace Module2_Exercise4;

internal class Program
{
    public static void Main(string[] args)
    {
        var mobile = new MobileNotification("09999999-99");
        var main = new MainNotification("vlad123@gmail.com");
        
        //Wrong.... Liskov principal.
        var machine  = new CoffeeMachine();

        SendNoficicaitionLogic(mobile);

        //IoC container.
        var collection = new ServiceCollection();
        
        collection
            .AddTransient<IFork, LongFork>()
            .AddTransient<IBladable>((x) => new Blade() {  Type = "Machete" })
            .AddTransient<IKnife, DishKnife>()
            .AddTransient<IPlate, Plate>()
            .AddTransient<Application>();

        Application app = collection.BuildServiceProvider().GetService<Application>();
        app.Run();

        IFork fork = new LongFork();
        IBladable blade = new Blade { Type = "Machete" };

        //AddTransient
        IKnife knife1 = new DishKnife(blade);
        IKnife knife2 = new DishKnife(blade);

        IPlate plate = new Plate(fork, knife1, knife2);

        //AddSingletone
        IKnife knife3 = new DishKnife(blade);
        IPlate plate1 = new Plate(fork, knife3, knife3);

        var application = new Application(plate);
        application.Run();
    }

    public static void SendNoficicaitionLogic(INotificationService notificationService)
    {
        notificationService.SendNotification();
    }

    public static void TakeKnife(IKnife knife, ISharpenable sharpenable)
    {
        sharpenable.Sharpen();
        knife.Cut(new Food());
    }
}

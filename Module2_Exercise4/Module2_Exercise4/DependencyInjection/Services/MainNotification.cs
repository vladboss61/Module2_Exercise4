using System;

namespace Module2_Exercise4.DependencyInjection.Services;

internal class MainNotification : INotificationService
{
    private readonly string _email;

    public MainNotification(string email)
    {
        _email = email;
    }

    public void SendNotification()
    {
        Console.WriteLine($"Send Message mail box {_email}.");
    }
}

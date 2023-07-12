using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2_Exercise4.DependencyInjection.Services;
internal class MobileNotification : INotificationService
{
    private readonly string _phoneNumber;
    public MobileNotification(string phoneNumber)
    {
        _phoneNumber = phoneNumber;
    }

    public void SendNotification()
    {
        Console.WriteLine($"Send Message to number {_phoneNumber}.");
    }
}

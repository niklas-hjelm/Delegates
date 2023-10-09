using DogMaster.Models;

namespace DogMaster;
public class DogServicesHandler
{

    public void ExecuteService(string selectedService, Dog dog)
    {
        var service = new DogService();
        service.Dog = dog;

        var discount = 0.75;

        switch (selectedService)
        {
            case "nailClipping":
                service.Price = 200;
                service.PerformService((discount) =>
                {
                    Console.WriteLine($"{dog.Name} has got its nails clipped! Final price: {service.Price * discount}");
                }, discount);
                break;
            case "trimming":
                service.Price = 400;
                service.PerformService((discount) =>
                {
                    Console.WriteLine($"{dog.Name} has got its fur trimmed! Final price: {service.Price * discount}");
                }, discount);
                break;
            case "walk":
                service.Price = 200;
                service.PerformService((discount) =>
                {
                    Console.WriteLine($"{dog.Name} has been on a walk! Final price: {service.Price * discount}");
                }, discount);
                break;
            case "bath":
                service.Price = 300;
                service.PerformService((discount) =>
                {
                    Console.WriteLine($"{dog.Name} smells like roses! Final price: {service.Price * discount}");
                }, discount);
                break;
            case "lunch":
                service.Price = 30;
                service.PerformService((discount) =>
                {
                    Console.WriteLine($"{dog.Name} ate all of the grub! Final price: {service.Price * discount}");
                }, discount);
                break;
        }
    }
}
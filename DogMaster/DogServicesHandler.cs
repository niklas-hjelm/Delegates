using DogMaster.Models;

namespace DogMaster;
public class DogServicesHandler
{

    public void ExecuteService(string selectedService, Dog dog)
    {
        var service = new DogService();
        service.Dog = dog;

        switch (selectedService)
        {
            case "nailClipping":
                service.PerformService(() => 
                {
                    Console.WriteLine($"{dog.Name} has got its nails clipped!");
                });
                break;
            case "trimming":
                service.PerformService(() =>
                {
                    Console.WriteLine($"{dog.Name} has got its fur trimmed!");
                });
                break;
            case "walk":
                service.PerformService(() =>
                {
                    Console.WriteLine($"{dog.Name} has been on a walk!");
                });
                break;
            case "bath":
                service.PerformService(() =>
                {
                    Console.WriteLine($"{dog.Name} smells like roses!");
                });
                break;
        }
    }
}
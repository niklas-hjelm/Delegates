using DogMaster.Models;
using static DogMaster.Models.DogService;

namespace DogMaster;
public class DogServicesHandler
{
    public Dictionary<string, Action<double>> Services { get; set; }

    public DogServicesHandler()
    {
        Services = new Dictionary<string, Action<double>>();
        Services.Add("nailClipping", discount =>
        {
            Console.WriteLine($"Your dog got its nails clipped!");
        });
        Services.Add("trimming", discount =>
        {
            Console.WriteLine($"Your dog has got its fur trimmed!");
        });
        Services.Add("walk", discount =>
        {
            Console.WriteLine($"Your dog got a walk!");
        });
        Services.Add("bath", discount =>
        {
            Console.WriteLine($"Your dog got a bath!");
        });
        Services.Add("lunch", discount =>
        {
            Console.WriteLine($"Your dog ate its lunch!");
        });
    }

    public void ExecuteService(string selectedService, Dog dog)
    {
        var service = new DogService();
        service.Dog = dog;

        var discount = 0.75;

        if (Services.ContainsKey(selectedService))
        {
            Services[selectedService](discount);
        }
    }
}
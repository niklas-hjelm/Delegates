namespace DogMaster.Models;
public class DogService
{
    public Dog Dog { get; set; }

    public double Price { get; set; }

    public delegate void Service(double discount);

    public void PerformService(Action<double> service, double discount)
    {
        service(discount);
    }
}

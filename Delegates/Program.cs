// See https://aka.ms/new-console-template for more information

using DogMaster;
using DogMaster.Models;

var dogServiceHandler = new DogServicesHandler();

var zoe = new Dog() { Name = "Zoe" };

while (true)
{
    var selection = Console.ReadLine();

    if(selection == "")
    { 
        break; 
    }

    dogServiceHandler.ExecuteService(selection, zoe);
}


Func<double, double, double> add = (d, d1) => d+d1;

double result = add(1,2);

Console.WriteLine(result);

var add2 =  (double d, double d2) => d+d2;

Dictionary<string, Action> names = new Dictionary<string, Action>();

names.Add("Niklas", ()=>{Console.WriteLine("Tjohoo");});

var input = Console.ReadLine();

names[input]();
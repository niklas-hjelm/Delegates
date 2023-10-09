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
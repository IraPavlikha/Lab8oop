using System;
using System.Collections.Generic;

class Vehicle
{
    public string Brand { get; set; }
    public string Model { get; set; }

    public virtual void Start()
    {
        Console.WriteLine($"Автомобіль {Brand} {Model} запускається.");
    }

    public virtual void Stop()
    {
        Console.WriteLine($"Автомобіль {Brand} {Model} зупиняється.");
    }
}

class Car : Vehicle
{
    public int NumberOfDoors { get; set; }
    public override void Start()
    {
        Console.WriteLine($"Автомобіль з {NumberOfDoors} дверима {Brand} {Model} запускається.");
    }

    public void Accelerate()
    {
        Console.WriteLine($"Автомобіль {Brand} {Model} набирає швидкість.");
    }
}

class Bicycle : Vehicle
{
    public bool HasBasket { get; set; }
    public override void Start()
    {
        Console.WriteLine($"Велосипед {Brand} {Model} починає рух.");
    }
}

class Program
{
    static void Main()
    {
        List<Vehicle> vehicles = new List<Vehicle>
        {
            new Car { Brand = "Toyota", Model = "Camry", NumberOfDoors = 4 },
            new Car { Brand = "Honda", Model = "Civic", NumberOfDoors = 2 },
            new Bicycle { Brand = "Giant", Model = "Escape", HasBasket = true },
            new Bicycle { Brand = "Trek", Model = "FX", HasBasket = false }
        };

        foreach (var vehicle in vehicles)
        {
            vehicle.Start();
            vehicle.Stop();
            
            if (vehicle is Car car)
            {
                car.Accelerate();
            }

            Console.WriteLine();
        }

        Console.WriteLine("Тест для автомобілів завершено.");
    }
}
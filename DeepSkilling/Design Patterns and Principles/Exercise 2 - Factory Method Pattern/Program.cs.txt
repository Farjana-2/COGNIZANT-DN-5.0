using System;

class Program
{
    static void Main(string[] args)
    {
        IVehicle v1 = VehicleFactory.GetVehicle("Car");
        v1.Show();

        IVehicle v2 = VehicleFactory.GetVehicle("Bike");
        v2.Show();

        Console.ReadLine();
    }
}
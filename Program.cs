using System;

namespace CarsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("test type", 10, 100, 20);
            SportCar sportCar = new SportCar(10, 30, 100);
            PassengerCar passengerCar = new PassengerCar(5, 100, 60, 4, 2);
            FreightCar freightCar = new FreightCar(20, 1000, 50, 2000, 2000);

            Console.WriteLine("Car:");
            car.CurrentFuelAmount -= 50;
            Console.WriteLine($"time to arrive: {car.CalculateArrivalTime(20)} hours");
            Console.WriteLine($"runtime left: {car.CalculateRunTime()} hours");
            car.ShowCurrentStatus();
            Console.WriteLine("-----------------");

            Console.WriteLine("Sportcar:");
            sportCar.CurrentFuelAmount -= 10;
            Console.WriteLine($"time to arrive: {sportCar.CalculateArrivalTime(20)} hours");
            Console.WriteLine($"runtime left: {sportCar.CalculateRunTime()} hours");
            car.ShowCurrentStatus();
            Console.WriteLine("-----------------");

            Console.WriteLine("Passenger car:");
            Console.WriteLine($"time to arrive: {passengerCar.CalculateArrivalTime(100)} hours");
            Console.WriteLine($"2 passengers: {passengerCar.CalculateRunTime()} runtime hours");
            passengerCar.CurrentPassengers -= 1;
            Console.WriteLine($"1 passenger: {passengerCar.CalculateRunTime()} runtime hours");
            passengerCar.CurrentFuelAmount -= 10;
            passengerCar.ShowCurrentStatus();
            Console.WriteLine("-----------------");

            Console.WriteLine("Freight car:");
            Console.WriteLine($"time to arrive: {freightCar.CalculateArrivalTime(100)} hours");
            Console.WriteLine($"load 2000 kg: {freightCar.CalculateRunTime()} runtime hours");
            freightCar.CurrentLoad = 200;
            Console.WriteLine($"load 200 kg: {freightCar.CalculateRunTime()} runtime hours");
            freightCar.CurrentLoad = 0;
            Console.WriteLine($"load 0 kg: {freightCar.CalculateRunTime()} hours");
            freightCar.CurrentFuelAmount -= 100;
            freightCar.ShowCurrentStatus();
            Console.WriteLine("-----------------");

            Console.ReadLine();
        }
    }
}

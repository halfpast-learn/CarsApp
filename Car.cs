using System;

namespace CarsApp
{
    class Car
    {
        public string vehicleType;
        public double averageFuelConsumption;
        public int fuelTankVolume;
        public double speed;

        private int _currentFuelAmount;
        public int CurrentFuelAmount
        {
            get => _currentFuelAmount;
            set
            {
                if (value > this.fuelTankVolume)
                {
                    throw new Exception("More fuel than possible");
                }

                _currentFuelAmount = value;
            }
        }


        public Car(string type, double consumption, int tankVolume, double speed)
        {
            vehicleType = type;
            averageFuelConsumption = consumption;
            fuelTankVolume = tankVolume;
            CurrentFuelAmount = fuelTankVolume;
            this.speed = speed;
        }


        public virtual double CalculateRunTime(Boolean onFullTank = false)
        {
            return (onFullTank ? this.fuelTankVolume : this.CurrentFuelAmount) / this.averageFuelConsumption;
        }

        public virtual void ShowCurrentStatus()
        {
            Console.WriteLine($"{this.CalculateRunTime()} hours out of {this.CalculateRunTime(true)} hours left");
        }

        public virtual double CalculateArrivalTime(double distance)
        {
            return Math.Min(distance / this.speed, this.CalculateRunTime());
        }
    }
}

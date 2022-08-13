using System;

namespace CarsApp
{
    class PassengerCar : Car
    {
        public int maxPassengers;

        private int _currentPassengers;
        public int CurrentPassengers
        {
            get => _currentPassengers;
            set
            {
                if (value > this.maxPassengers)
                {
                    throw new Exception("More passengers than possible");
                }
                this._currentPassengers = value;
            }
        }

        public PassengerCar(double consumption, int tankVolume, double speed, int maxPassengers, int passengers) : base("Passenger car", consumption, tankVolume, speed)
        {
            this.maxPassengers = maxPassengers;
            this.CurrentPassengers = passengers;
        }

        public override double CalculateArrivalTime(double distance)
        {
            return base.CalculateArrivalTime(distance);
        }

        public override double CalculateRunTime(Boolean onFullTank = false)
        {
            return base.CalculateRunTime(onFullTank) * (1 - 0.06 * CurrentPassengers);
        }

        public override void ShowCurrentStatus()
        {
            base.ShowCurrentStatus();
            Console.WriteLine($"{this.CurrentPassengers} out of {this.maxPassengers} passengers");
        }
    }
}

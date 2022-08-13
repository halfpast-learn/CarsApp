using System;

namespace CarsApp
{
    class FreightCar : Car
    {
        public int MaxLoad { get; set; }

        private int _currentLoad;
        public int CurrentLoad
        {
            get => _currentLoad;
            set
            {
                if (value > this.MaxLoad)
                {
                    throw new Exception("More load than possible");
                }
                this._currentLoad = value;
            }
        }

        public FreightCar(double consumption, int tankVolume, double speed, int maxLoad, int load) : base("Freight car", consumption, tankVolume, speed)
        {
            this.MaxLoad = maxLoad;
            this.CurrentLoad = load;
        }

        public override double CalculateArrivalTime(double distance)
        {
            return base.CalculateArrivalTime(distance);
        }

        public override double CalculateRunTime(Boolean onFullTank = false)
        {
            return base.CalculateRunTime(onFullTank) * (1 - 0.04 * this.CurrentLoad / 200);
        }

        public override void ShowCurrentStatus()
        {
            base.ShowCurrentStatus();
            Console.WriteLine($"{this.CurrentLoad} kg out of {this.MaxLoad} kg");
        }
    }
}

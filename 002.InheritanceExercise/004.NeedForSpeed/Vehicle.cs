namespace NeedForSpeed
{
    public class Vehicle
    {
        const double DefaultFuelConsumption = 1.25;
        private int horsePower;
        private double fuel;

        public int HorsePower
        {
            get;
            set;
        }

        public double Fuel
        {
            get;
            set;
        }

        public virtual double FuelConsumption
        {
            get 
            { 
                return DefaultFuelConsumption;
            }
        }

        public Vehicle(int horsePower, double fuel)
        {
            this.HorsePower = horsePower;
            this.Fuel = fuel;
        }

        public virtual void Drive(double kilometers)
        {
            Fuel -= FuelConsumption * kilometers;
        }
    }
}

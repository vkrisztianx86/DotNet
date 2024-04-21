using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace CarRegistrator
{
    public class Car
    {

        static int AllCars;
        public string LicensePlate {  get; }

        public CarEnum Type { get; }

        List<double> Consumption;

        public double amortization = 100;

        static Car()
        {
            AllCars = 0;
        }
        public Car(string lp, CarEnum typ)
        {
            LicensePlate = lp;
            Type = typ;
            Consumption = new List<double>();
            AllCars++;
        }

       public static int AllCar()
        {
            return AllCars;
        }

        public void Go(double consumption)
        {
            Consumption.Add(consumption);
        }

        public double AvgConsumption()
        {
            double sum = 0;
            foreach (double item in Consumption)
            {
                sum += item;
            }
            Amortization();
            return sum / Consumption.Count;
        }

        private void Amortization()
        {
            amortization = amortization-amortization * 0.001;
        }
    }
}

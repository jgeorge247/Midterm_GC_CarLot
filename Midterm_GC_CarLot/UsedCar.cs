using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_GC_CarLot
{
    class UsedCar : Car
    {
        public double Mileage { get; set; }

        public UsedCar(string make, string model, int year, double price, double mileage) 
            : base(make, model, year, price)
        {
            Mileage = mileage;
        }

        public override string ToString()
        {
            string result = base.ToString() + $"\tMileage: {Mileage}";
            return result;
        }
    }
}

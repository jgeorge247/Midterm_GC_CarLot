using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_GC_CarLot
{
    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double Price { get; set; }

        public Car()
        {

        }

        public Car(string make, string model, int year, double price)
        {
            Make = make;
            Model = model;
            Year = year;
            Price = price;
        }

        public override string ToString()
        {
            string result = $"Make: {Make} \tModel: {Model} \tYear: {Year} \tPrice: {Price}";
            return result;
        }
    }
}

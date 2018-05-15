using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_GC_CarLot
{
    class CarLot
    {
        public static List<Car> CarList()
        {
            List<Car> cars = new List<Car>();
            cars.Add(new Car("Honda", "CR-V", 2018, 29000.00));
            cars.Add(new Car("Audi", "A7", 2018, 70000.00));
            cars.Add(new Car("BMW", "530i", 2018, 52000.00));
            cars.Add(new UsedCar("BMW", "i3", 2015, 17500.00, 10600));
            cars.Add(new UsedCar("Benz", "CLA250", 2015, 28000.00, 6000));
            cars.Add(new UsedCar("Volvo", "XC90", 2017, 43000.00, 8000));

            return cars;
        }
        public static int ValidateInput()
        {
            Console.WriteLine("Enter an option between 1-5");
            string Response = Console.ReadLine();
            int NumResponse = 0;
            bool valid = int.TryParse(Response, out NumResponse);
            while (!valid)
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                Response = Console.ReadLine();
                valid = int.TryParse(Response, out NumResponse);
            }
            return NumResponse;
        }
        public static void PrintList(List<Car> cars)
        {
            //List the car in inventory
            Console.WriteLine($"LIST OF CARS 1-{cars.Count}");
           
            int Counter = 0;
            foreach (Car c in cars)
            {
                Counter++;
                Console.WriteLine(Counter + ". " + c.ToString());
            }
        }
        public static Car AddCar()
        {
            string NewOld = "";
            bool Validate = true;
            while (Validate)
            {
            Console.WriteLine("Are you adding a new or used vehicle? (N/U)");
            NewOld = Console.ReadLine().ToUpper();
            
                if (NewOld == "U" || NewOld == "N")
                {
                    Validate = false;
                }
                else
                {
                    Console.WriteLine("That is not a valid input");
                }
            }
            if (NewOld == "N")
            {
                Console.WriteLine("Add a car: ");
                Console.WriteLine("Enter make");
                string input1 = Console.ReadLine();
                Console.WriteLine("Enter model");
                string input2 = Console.ReadLine();
                Console.WriteLine("Enter year between 1900-2020");
                string input3 = Console.ReadLine();

                int TrueYear;
                while (!int.TryParse(input3, out TrueYear) || TrueYear < 1900 || TrueYear > 2020)
                {
                    Console.WriteLine("Invalid input. Please enter a year between 1900-2020.");
                    input3 = Console.ReadLine();
                }
                Console.WriteLine("Enter the price");
                string input4 = Console.ReadLine();
                double TruePrice;
                while (!double.TryParse(input4, out TruePrice))
                {
                    Console.WriteLine("Invalid input. Please enter a valid price.");
                    input4 = Console.ReadLine();
                }
                Car car1 = new Car(input1, input2, TrueYear, TruePrice);
                Console.WriteLine("Car Added!");
                return car1;
            }
            else //(NewOld == "U")
            {
                Console.WriteLine("Add a car: ");
                Console.WriteLine("Enter make");
                string input1 = Console.ReadLine();
                Console.WriteLine("Enter model");
                string input2 = Console.ReadLine();
                Console.WriteLine("Enter year between 1900-2020");
                string input3 = Console.ReadLine();
                int TrueYear;
                while (!int.TryParse(input3, out TrueYear) || TrueYear < 1900 || TrueYear > 2020)
                {
                    Console.WriteLine("Invalid input. Please enter a year between 1900-2020.");
                    input3 = Console.ReadLine();
                }

                Console.WriteLine("Enter the price");
                string input4 = Console.ReadLine();
                double TruePrice;
                while (!double.TryParse(input4, out TruePrice))
                {
                    Console.WriteLine("Invalid input. Please enter a valid price.");
                    input4 = Console.ReadLine();
                }

                Console.WriteLine("Enter the mileage");
                string input5 = Console.ReadLine();
                int TrueMile;
                while (!int.TryParse(input3, out TrueMile))
                {
                    Console.WriteLine("Invalid input. Please enter valid mileage");
                    input5 = Console.ReadLine();
                }

                Car car2 = new UsedCar(input1, input2, TrueYear, TruePrice, TrueMile);
                Console.WriteLine("Car Added!");
                return car2;
            } 
        }
        public static void RemoveCar(List<Car> cars)
        {
            Console.WriteLine("Remove Car");
            Console.WriteLine($"Which car would you like to delete? (1-{cars.Count})");
            string DeleteCar = Console.ReadLine();

            //validate that it's within bounds
            int DeleteNumber;
            bool ValidDelete = int.TryParse(DeleteCar, out DeleteNumber);
            while (!ValidDelete || DeleteNumber < 0 || DeleteNumber > cars.Count)
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                DeleteCar = Console.ReadLine();
                ValidDelete = int.TryParse(DeleteCar, out DeleteNumber);
            }
            cars.RemoveAt(DeleteNumber - 1);
            Console.WriteLine("Congrats! That car is deleted!");
        }
        public static List<Car> LookUp(List<Car> cars)
        {
            //prompt user to select cars
            Console.WriteLine($"Select which car you would like to view (1-{cars.Count})");
            string ViewCar = Console.ReadLine();
            Console.WriteLine(cars[Convert.ToInt32(ViewCar) - 1].ToString());
            Console.WriteLine("Would you like to purchase? (Y/N)");
            string answer2 = Console.ReadLine().ToUpper();

            if (answer2 == "Y")
            {
                cars.RemoveAt(Convert.ToInt32(ViewCar) - 1);
            }
            return cars;
        }
    }           

}

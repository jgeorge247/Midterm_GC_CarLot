using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_GC_CarLot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Grand Circus Motors admin console!");
            List<Car> ListCar = CarLot.CarList();
            bool repeat = true;
            while (repeat == true)
            {
                Menu();

                int NumResponse = CarLot.ValidateInput();

                if (NumResponse == 1)
                {
                    CarLot.PrintList(ListCar);
                }
                else if (NumResponse == 2)
                {
                    Car car = CarLot.AddCar();
                    ListCar.Add(car);
                }
                else if (NumResponse == 3)
                {
                    CarLot.RemoveCar(ListCar);
                }
                else if (NumResponse == 4)
                {
                    ListCar = CarLot.LookUp(ListCar);
                }
                else if (NumResponse == 5)
                {
                    CarLot.PrintList(ListCar);
                    Console.WriteLine("Which car would you like to replace?: ");
                    int index = Convert.ToInt32(Console.ReadLine()) - 1;

                    Car car = CarLot.AddCar();
                    ListCar[index] = car;

                }
                Console.WriteLine("Would you like to continue? (Y/N)");
                string Response2 = Console.ReadLine().ToUpper();

                if (Response2 != "Y" || Response2 != "N")
                {
                    Console.WriteLine("Invalid input. Please write (Y/N)");
                    Response2 = Console.ReadLine();
                }
                else if (Response2 == "N")
                {
                     repeat = false;
                }
            }
        }
        static void Menu()
        {
            Console.WriteLine("\n1. List all cars");
            Console.WriteLine("2. Add a car");
            Console.WriteLine("3. Remove a car");
            Console.WriteLine("4. Look up a car in a given position");
            Console.WriteLine("5. Replace a car in a given position");
            Console.WriteLine("6. Quit");
        }
    }
}

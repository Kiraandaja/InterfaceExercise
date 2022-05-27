using System;
namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany
    {
        public Car()
        {
        }

        public double EngineSize { get; set; } = 4;
        public string Color { get; set; } = "Baby Blue";
        public int Year { get; set; } = 2022;
        public int SeatCount { get; set; } = 4;
        public string CompanyName { get; set; } = "Porche";
        public string Motto { get; set; } = "Winning Together";
        public bool HasChangedGears { get; set; }

        public void Drive()
        {
            Console.WriteLine($"{GetType().Name} now driving forward...");
         }
        public void Reverse()
        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} now driving forward...");

                HasChangedGears = false;
            }
            else
            {
                Console.WriteLine("Can't reverse until we change gears.");
            }

        }
        public void Park()
        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} now in park.");

                HasChangedGears = false;
            }
            else
            {
                Console.WriteLine("Can't park until we change gears.");
            }
        }
        

    }
}

using System;
namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {
        public Truck()
        {
        }
        public double EngineSize { get; set; } = 8;
        public string Color { get; set; } = "White";
        public int Year { get; set; } = 2022;
        public int SeatCount { get; set; } = 2;
        public string CompanyName { get; set; } = "Chevy";
        public string Motto { get; set; } = "Find New Roads";
        public bool HasChangedGears { get; set; }
        public bool HasFourWheelDrive { get; set; }

        public void Drive()
        {
            Console.WriteLine($"{GetType().Name} now driving forward...");
        }
        public void Reverse()
        {
            if (HasFourWheelDrive == true)
            {
                Console.WriteLine($"{GetType().Name} now driving forward...");

                HasFourWheelDrive = false;
            }
            else
            {
                Console.WriteLine("Can't reverse until we change gears.");
            }

        }
        public void Park()
        {
            if (HasFourWheelDrive == true)
            {
                Console.WriteLine($"{GetType().Name} now in park.");

                HasFourWheelDrive = false;
            }
            else
            {
                Console.WriteLine("Can't park until we change gears.");
            }

        }
    }
}

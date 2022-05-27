using System;
namespace InterfaceExercise
{
    public class SUV:  IVehicle, ICompany
    {
        public SUV()
        {
        }
        public double EngineSize { get; set; } = 4;
        public string Color { get; set; } = "Silver";
        public int Year { get; set; } = 2019;
        public int SeatCount { get; set; } = 2;
        public string CompanyName { get; set; } = "Honda";
        public string Motto { get; set; } = "The Power of Dreams.";
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

using System;
namespace InterfaceExercise
{
    public interface IVehicle
    {
        public double EngineSize { get; set; }
        public string Color { get; set; }
        public int Year { get; set; }
        public int SeatCount { get; set; }

        public void Drive();
        public void Reverse();
        public void Park();
    }
}

using System;
using Module2HW6.Enums;

namespace Module2HW6.Models
{
    public class Mercedes : RearDriveCar
    {
        public Mercedes(string name, DateTime dateOfManufacture, GearboxType gearbox, double accelerationTo100KM, double engineCapacity, int maneuverability, int generation)
            : base(name, dateOfManufacture, gearbox, accelerationTo100KM, engineCapacity, maneuverability)
        {
            Generation = generation;
        }

        public int Generation { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}\nDate of manufacture: {DateOfManufacture.ToShortDateString()}\nGearbox: {Gearbox}\nAcceleration to 100 km: {AccelerationTo100KM}s\nEngine capacity: {EngineCapacity}\nManeuverability: {Maneuverability}%\nGeneration: {Generation}\n";
        }
    }
}

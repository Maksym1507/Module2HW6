using System;
using Module2HW6.Enums;

namespace Module2HW6.Models
{
    public class BMW : RearDriveCar
    {
        public BMW(string name, DateTime dateOfManufacture, GearboxType gearbox, double accelerationTo100KM, double engineCapacity, int maneuverability, int numberOfAccidents)
            : base(name, dateOfManufacture, gearbox, accelerationTo100KM, engineCapacity, maneuverability)
        {
            NumberOfAccidents = numberOfAccidents;
        }

        public int NumberOfAccidents { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}\nDate of manufacture: {DateOfManufacture.ToShortDateString()}\nGearbox: {Gearbox}\nAcceleration to 100 km: {AccelerationTo100KM}s\nEngine capacity: {EngineCapacity}\nManeuverability: {Maneuverability}%\nNumber of accidents: {NumberOfAccidents}\n";
        }
    }
}

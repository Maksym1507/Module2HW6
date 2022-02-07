using System;
using Module2HW6.Enums;

namespace Module2HW6.Models
{
    public class RearDriveCar : Car
    {
        public RearDriveCar(string name, DateTime dateOfManufacture, GearboxType gearbox, double accelerationTo100KM, double engineCapacity, int maneuverability)
            : base(name, dateOfManufacture, gearbox, accelerationTo100KM, engineCapacity)
        {
            Maneuverability = maneuverability;
        }

        public int Maneuverability { get; set; }
    }
}

using System;
using Module2HW6.Exceptions;
using Module2HW6.Interfaces;

namespace Module2HW6.Models
{
    public class Transport
    {
        public Transport(string name, DateTime dateOfManufacture)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(name))
                {
                    Name = name;
                }
                else
                {
                    throw new Exception("Whitespace or NULL name of transport");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Name = "Undefined";
            }

            DateOfManufacture = dateOfManufacture;
        }

        public string Name { get; set; }

        public DateTime DateOfManufacture { get; set; }
    }
}

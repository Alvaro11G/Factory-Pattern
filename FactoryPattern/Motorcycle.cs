using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Motorcycle : IVehicle
    {
        public string? Color { get; set; }
        public bool Isfast { get; set; }

        public void Drive()
        {
            Console.WriteLine("Motorcycle is now in drive");
        }
    }
}

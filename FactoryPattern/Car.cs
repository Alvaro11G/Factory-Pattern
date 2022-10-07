using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Car : IVehicle
    {
        public string? Color { get; set; }
        public bool IsDriveable { get; set;}

        public void Drive()
        {
            Console.WriteLine("Car is in Drive");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class VehicleFactory
    {
        public IVehicle CreateVehicle(string userInput)
        {
            switch (userInput!.ToLower())
            {
                case "car":
                    return new Car() { Color = "red", IsDriveable = true};
                case "motorcycle":
                    return new Motorcycle() { Color = "black", Isfast = true};
                default:
                    return new Car();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution.Vehicles
{
    public class Vehicle
    {
        public string Car { get; }
        public string Motorcycle { get; }
        public string Airplane { get; }
        public virtual void StartEngine()
        {
            Console.WriteLine("The engine is starting");
        }
    }
}

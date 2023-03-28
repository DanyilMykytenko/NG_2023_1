using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed
{
    public class Auto
    {
        public string Company { get; set; }
        public string Model { get; set; }

        public virtual void GetInfo()
        {
            Console.WriteLine($"Company: {Company} and Model: {Model}");
        }
    }
}

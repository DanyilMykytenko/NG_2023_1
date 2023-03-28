using InterfaceSegregation.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation.Classes
{
    public class Triangle : ITriangle
    {
        public void DrawTriangle()
        {
            Console.WriteLine("WOW, IT'S A TRIANGLE");
        }
    }
}

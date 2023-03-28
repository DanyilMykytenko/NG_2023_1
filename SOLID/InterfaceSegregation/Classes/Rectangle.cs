using InterfaceSegregation.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation.Classes
{
    public class Rectangle : IRectangle
    {
        public void DrawRectangle()
        {
            Console.WriteLine("WOW, IT'S A RECTANGLE");
        }
    }
}

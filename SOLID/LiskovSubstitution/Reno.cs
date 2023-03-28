using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution
{
    public class Reno : Auto
    {
        public int RenoFeature { get; set; }
        public override void GetInfo()
        {
            Console.WriteLine($"Company: {Company} and Model: {Model}, BUT OUR FEATURE IS: {RenoFeature}");
        }
    }
}

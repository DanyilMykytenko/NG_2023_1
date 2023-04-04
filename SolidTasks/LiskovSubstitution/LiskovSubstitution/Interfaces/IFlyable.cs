using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution.Interfaces
{
    public interface IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("It's flying?");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation.Interfaces
{
    public interface IShape
    {
        public void DrawCircle();
        public void DrawRectangle();
        public void DrawTriangle();
    }
}

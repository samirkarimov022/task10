using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    internal class Laptop:Device
    {
        public int PortCount;
        public Laptop(decimal width, decimal height, decimal weight, int portCount):base(width, height,weight) 
        {
           PortCount = portCount;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    internal class Device
    {
        public decimal Width;
        public decimal Height;
        public decimal Weight;
        public bool IsOpening = false;
        public Device(decimal width, decimal height, decimal weight)
        {
            Width = width;
            Height = height;
            Weight = weight;
        }

        public void OpenDevice()
        {
            if (!IsOpening)
            {
            Console.WriteLine("open device");
                IsOpening = true;
            }
            else 
            {
                Console.WriteLine("already opening");          
            }
        }
        public void CloseDevice()
        {
            if (IsOpening)
            {
             Console.WriteLine("close device");
                IsOpening= false;
            }
            else
            {
                Console.WriteLine("already closed");
            }
        }


    }
}

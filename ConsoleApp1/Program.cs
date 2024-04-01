using ConsoleApp1.Models;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Device device = new Device(10,10,10);
            device.OpenDevice();
            device.CloseDevice();
            device.CloseDevice();
            device.OpenDevice();
            device.CloseDevice();

            Mobile number = new Mobile(10,10,10,2);
            number.AddNumber("0997550345");
            number.AddNumber("0102329856");
            number.GetNumber();
            number.RemoveNumber("0997550345");
            number.GetNumber();


        }
    }
}

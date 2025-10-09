using System.Threading.Channels;

namespace zad3
{
    class Vehicle
    {
        public void Drive()
        {
            Console.WriteLine("drive");
        }
    }

    class Car : Vehicle
    {
        public new void Drive()
        {
            Console.WriteLine("samochód jedzie");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Car veh = new Car();
            veh.Drive();
        }
    }
}

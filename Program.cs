using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_Cars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car Ford = new Car("mustang", "blue", 2010, 220);
            Car Opel = new Car("astra", "red", 2020, 180);

            Console.WriteLine(Ford.name);
            Console.WriteLine(Opel.year);
            Console.WriteLine(Ford.color);
            Ford.fullThrottle();

            Console.WriteLine(Opel.name);
            Console.WriteLine(Opel.year);
            Console.WriteLine(Ford.color);
            Opel.fullThrottle();
            Console.ReadKey();
        }
    }
}

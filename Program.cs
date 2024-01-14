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
            Car Ford = new Car("mustang", "blue", 2021, 220);
            Car Opel = new Car("astra", "red", 2020, 180, "electric");
            Car Volvo = new Car("xc90");

            Console.WriteLine(Ford.Name);
            Console.WriteLine(Opel.Year);
            Console.WriteLine(Ford.Color);
            Console.WriteLine(Ford.engine_type);
            Ford.fullThrottle();
            Ford.honk();

            Console.WriteLine(Opel.Name);
            Console.WriteLine(Opel.Year);
            Console.WriteLine(Ford.Color);
            Opel.fullThrottle();
            Opel.honk();
            Console.ReadKey();

            Console.WriteLine("Enter Volvo's age = ");
            try
            {
                Volvo.Year = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Volvo's age is " + Volvo.Year);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jarmuvekApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Motor motor = new Motor(2.5, default, "XLC-452");
            Console.WriteLine("Motor: "+motor.ToString());
            Szemelyauto auto = new Szemelyauto(5.5, default, "ABC-123");
            Console.WriteLine("Autó: " + auto.ToString());
            Busz busz = new Busz(10.5, default, "BKK-222");
            Console.WriteLine("Busz:" + busz.ToString());
            Munkagep gep = new Munkagep(25.5, default, "XZK-654");
            Console.WriteLine("Munkagép: " + gep.ToString());
            Console.ReadKey();

        }
    }
}

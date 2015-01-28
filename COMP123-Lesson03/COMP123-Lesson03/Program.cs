using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_Lesson03
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car("Honda", "Pilot", "Black", "X12345");
            myCar.driveForward();



            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}

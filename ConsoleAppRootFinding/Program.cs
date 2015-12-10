using NewtonMethodLogik;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppRootFinding
{
    class Program
    {
        static void Main(string[] args)
        {
            double number;
            double precision;
            int power;

            Console.WriteLine("Enter your number");
            Double.TryParse(Console.ReadLine(), out number);
            Console.WriteLine("Enter the desired power");
            Int32.TryParse(Console.ReadLine(), out power);
            Console.WriteLine("Enter the required precision");
            Double.TryParse(Console.ReadLine(), out precision);

            double xNewton = RootFinding.NewtonMetode(number, power, precision);
            Console.WriteLine("NewtonMetod Result : x = " + xNewton);
            double xPow = Math.Pow(number, 1.0 / power);
            Console.WriteLine("Math.Root Result : x = " + xPow);


            if (xNewton == xPow)
            {
                Console.WriteLine(xNewton + " = " + xPow);
            }
            Console.ReadLine();
        }
    }
}

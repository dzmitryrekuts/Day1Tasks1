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
            double power;


            Console.WriteLine("Enter your number");
            Double.TryParse(Console.ReadLine(), out number);
            Console.WriteLine("Enter the desired power");
            Double.TryParse(Console.ReadLine(), out power);
            double reversPower = 1 / power;
            Console.WriteLine("Enter the required precision");
            Double.TryParse(Console.ReadLine(), out precision);

            double xNewton = RootFinding.NewtonMetode(number, precision, power);
            Console.WriteLine("NewtonMetod Result : x = " + xNewton + "()");
            double xPow = Math.Pow(number, reversPower);
            Console.WriteLine("Math.Root Result : x = " + xPow);


            if (xNewton == xPow)
            {
                Console.WriteLine(xNewton + " = " + xPow);
            }

            Console.ReadLine();
        }
    }
}

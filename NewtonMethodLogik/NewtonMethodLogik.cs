using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewtonMethodLogik
{
    public class RootFinding
    {

        public static double NewtonMetode(double number, int power, double precision)
        {
            if ((number < 0 && power % 2 == 0) || precision <= 0)
            {
                throw new ArgumentException();
            }

            double x = number / power;

            for (;;)
            {
                double nx = ((power - 1) * x + number / Math.Pow(x, power - 1)) / power;
                if (Math.Abs(x - nx) < precision)
                {
                    break;
                }
                x = nx;
            }


            return x;
        }
    }
}


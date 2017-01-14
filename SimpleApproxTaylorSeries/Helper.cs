using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleApproxTaylorSeries
{
    public static class Helper
    {
        public static double DegreeToRadian(double x)
        {
            return Math.PI * x / 180.0;
        }

        public static int Factorial(int x)
        {
            if (x == 0)
                return 1;

            int factorial = 1;
            do
            {
                factorial *= x;
                x--;
            } while (x > 0);
            return factorial;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
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

        public static double Factorial(int x)
        {
            return (double) MathNet.Numerics.SpecialFunctions.Factorial(new BigInteger(x));
        }
    }
}

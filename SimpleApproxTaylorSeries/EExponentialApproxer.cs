using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleApproxTaylorSeries
{
    public static partial class TaylorApproxer
    {
        public static double EExponential(double x, int accuracy)
        {
            var lastSum = Double.MaxValue;

            var sum = 0.0;
            int i = 0;
            while (Math.Abs(sum - lastSum) > 1 / Math.Pow(10, accuracy))
            {
                lastSum = sum;
                var r = Math.Pow(x, i) / Helper.Factorial(i);
                sum += r;
                ++i;
            }
            return sum;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleApproxTaylorSeries
{
    public static partial class TaylorApproxer
    {
        public static double Arctangent(double x, int accuracy)
        {
            var lastSum = Double.MaxValue;

            var sum = 0.0;
            int i = 0;
            while (Math.Abs(sum - lastSum) > 1 / Math.Pow(10, accuracy))
            {
                lastSum = sum;
                double xRadian = Helper.DegreeToRadian(x);
                var r = Math.Pow(-1, i) * Math.Pow(xRadian, 1 + 2 * i) / (1 + 2 * i);
                sum += r;
                ++i;
            }
            return sum;
        }
    }
}

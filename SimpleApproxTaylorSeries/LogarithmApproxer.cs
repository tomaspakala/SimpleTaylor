using System;
using System.Collections.Generic;
using System.Numerics;

namespace SimpleApproxTaylorSeries
{
    public static partial class TaylorApproxer
    {
        public static double Logarithm(double x, int accuracy)
        {
            double lastSum = Double.MaxValue;

            var sum = 0.0;
            int i = 0;
            var x1 = x - 1;
            if (Math.Abs(x) > 1)
                sum += Math.Log(x1);

            while (Math.Abs(sum - lastSum) > 1 / Math.Pow(10, accuracy))
            {
                lastSum = sum;
                ++i;
                if (Math.Abs(x) <= 1)
                {
                    var r = Math.Pow(-1, i + 1) * Math.Pow(x1, i) / i;
                    sum += r;
                }
                else
                {
                    var r = Math.Pow(-1, i + 1) * Math.Pow(x1, -1 * i) / i;
                    sum += r;
                }
            }
            return sum;
        }
    }

}

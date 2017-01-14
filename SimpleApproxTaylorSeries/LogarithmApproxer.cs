using System;
using System.Collections.Generic;
using System.Numerics;

namespace SimpleApproxTaylorSeries
{
    public static partial class TaylorApproxer
    {
        public static double Logarithm(double x, int accuracy)
        {
            double acc = Math.Pow(10, accuracy);
            double adjusted = Adjuster(Math.Log(x), acc);

            var sum = 0.0;
            int i = 0;
            while (adjusted != Adjuster(sum, acc))
            {
                ++i;
                var r = Math.Pow(-1, i) * Math.Pow(x-1, i) / i;
                sum -= r;
            }
            return sum;
        }
    }

}

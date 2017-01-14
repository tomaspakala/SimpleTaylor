using System;
using System.Collections.Generic;
using System;
using System.Numerics;

namespace SimpleApproxTaylorSeries
{
    public static partial class TaylorApproxer
    {
        public static double Exponential(double a, double x, int accuracy)
        {
            double acc = Math.Pow(10, accuracy);
            double adjusted = Adjuster(Math.Pow(a, x), acc);

            var sum = 0.0;
            int i = 0;
            while (adjusted != Adjuster(sum, acc))
            {
                var r = Math.Pow(x, i) * Math.Pow(Math.Log(a), i) / Helper.Factorial(i);
                sum += r;
                ++i;

                if (i > 20)
                    throw new NotSupportedException();
            }
            return sum;
        }
    }
        
}

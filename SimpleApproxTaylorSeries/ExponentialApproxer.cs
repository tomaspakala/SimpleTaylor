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
            var lastSum = Double.MaxValue;

            var sum = 0.0;
            int i = 0;
            while (Math.Abs(sum - lastSum) > 1 / Math.Pow(10, accuracy))
            {
                lastSum = sum;
                var r = Math.Pow(x, i) * Math.Pow(Math.Log(a), i) / Helper.Factorial(i);
                sum += r;
                ++i;
            }
            return sum;
        }
    }
        
}

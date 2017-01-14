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

            if (Math.Abs(x - 1.0) > 1)
            {
                sum = sum + LogarithmDiv(x - 1.0, accuracy);
            }

            while (Math.Abs(sum - lastSum) > 1 / Math.Pow(10, accuracy))
            {
                lastSum = sum;
                ++i;
                var r = Math.Pow(-1, i + 1) * Math.Pow(x - 1, i) / i;
                sum += r;
            }
            return sum;
        }

        public static double LogarithmDiv(double x, int accuracy)
        {
            double lastSum = Double.MaxValue;

            var sum = 0.0;
            int i = 0;

            if (Math.Abs(x - 1.0) > 1)
            {
                sum = sum + LogarithmDiv(x - 1.0, accuracy);
            }

            while (Math.Abs(sum - lastSum) > 1 / Math.Pow(10, accuracy))
            {
                lastSum = sum;
                ++i;
                var r = Math.Pow(-1, i + 1) / Math.Pow(x - 1, i) / i;
                sum += r;
            }
            return sum;
        }
    }

}

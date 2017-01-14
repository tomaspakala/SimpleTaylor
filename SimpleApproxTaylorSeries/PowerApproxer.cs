using System;

namespace SimpleApproxTaylorSeries
{
    public static partial class TaylorApproxer
    {
        public static double Power(double x, double power, int accuracy)
        {
            var close = FindClose(x, power);
            double x0 = x / close - 1;
            double sum = 0;
            double lastSum = Double.MaxValue;
            int i = 0;
            double acc = 1;
            while (Math.Abs(sum - lastSum) > 1 / Math.Pow(10, accuracy))
            {
                lastSum = sum;
                sum += (acc* Math.Pow(x0, i)) / Helper.Factorial(i);
                acc *= power - i;
                ++i;
            }
            return Math.Pow (close, power) *sum;
        }

        private static int FindClose(double x, double power)
        {
           var close = (int) Math.Round(x);
           while (Math.Pow(close, power) % 1 != 0)
                --close;
           return close;
        }
    }
}

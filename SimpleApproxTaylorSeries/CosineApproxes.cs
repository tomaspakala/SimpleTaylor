using System;
using System.Numerics;

namespace SimpleApproxTaylorSeries
{
    public static partial class TaylorApproxer
    {   
        public static double Cosine(double x, int accuracy)
        {
            double sum = 0;
            double lastSum = Double.MaxValue;
            int i = 0;
            while (Math.Abs(sum - lastSum) > 1 / Math.Pow(10, accuracy))
            {
                lastSum = sum;
                double xRadian = Helper.DegreeToRadian(x);
                sum += Math.Pow(-1, i) * Math.Pow(xRadian, 2 * i) / Helper.Factorial(2 * i);
                ++i;
            }
            return sum;
        }
    }
}

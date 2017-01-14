using System;
using System.Numerics;

namespace SimpleApproxTaylorSeries
{
    public static partial class TaylorApproxer
    {
        public static double Tangent(double x, int accuracy)
        {
            double sum = 0;
            double lastSum = Double.MaxValue;
            double xRadian = Helper.DegreeToRadian(x);
            int i = 0;
            while (Math.Abs(sum - lastSum) > 1 / Math.Pow(10, accuracy + 1))
            {
                //to do
            }
            return sum;
        }
    }
}
using System;
using System.Numerics;

namespace SimpleApproxTaylorSeries
{
    public static partial class TaylorApproxer
    {
        public static double Tangent(double x, int accuracy)
        {
            return Sine(x, accuracy) / Cosine(x, accuracy);
        }
    }
}
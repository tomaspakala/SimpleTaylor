using System;
using System.Numerics;

namespace SimpleApproxTaylorSeries
{
    public static class TaylorApproxer
    {
        public static double Power(double x, double power, int accuracy)
        {
            Func<double, double> pow = delegate(double xx)
            {
                return Math.Pow(xx, power); 
            };

            double acc = Math.Pow(10, accuracy);
            double adjusted = Adjuster(Math.Pow(x, power), acc);

            int x0 = FindClose(x, power);

            var sum = pow.Invoke(x0);

            int i = 0;
            while (adjusted != Adjuster(sum, acc))
            {
                ++i;
                var f = MathNet.Numerics.Differentiate.DerivativeFunc(pow, i);

                var r = (f.Invoke(x0)* Math.Pow(x - x0, i))/(double) MathNet.Numerics.SpecialFunctions.Factorial(new BigInteger(i));
                sum += r;

                if (i > 20)
                    throw new NotSupportedException();
            }

            return sum;
        }

        public static double Sine(double x, int accuracy)
        {
            double xRadian = DegreeToRadian(x);

            Func<double, double> pow = delegate (double xx)
            {
                return Math.Sin(xx);
            };

            double acc = Math.Pow(10, accuracy);
            double adjusted = Adjuster(Math.Sin(xRadian), acc);

            int x0 = 0;

            var sum = pow.Invoke(x0);

            int i = 0;
            while (adjusted != Adjuster(sum, acc))
            {
                ++i;
                var f = MathNet.Numerics.Differentiate.DerivativeFunc(pow, i);

                var r = (f.Invoke(x0) * Math.Pow(xRadian - x0, i)) / (double)MathNet.Numerics.SpecialFunctions.Factorial(new BigInteger(i));
                sum += r;

                if (i > 20)
                    throw new NotSupportedException();
            }

            return sum;
        }

        private static double DegreeToRadian(double x)
        {
            return Math.PI * x / 180.0;
        }

        private static double Adjuster(double x, double accuracity)
        {
            accuracity *= 10;
            return Math.Truncate(accuracity * x) / accuracity;
        }

        private static int FindClose(double x, double power)
        {
            var close = (int)Math.Pow(x, power);

            if (close == 1)
                ++close;

            while (Math.Pow(close, power) % 1 != 0)
                close++;

            return close;
        }

    }
}

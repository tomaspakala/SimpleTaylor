using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleApproxTaylorSeries
{
    public static partial class TaylorApproxer
    {
        public static double EExponential(double x, int accuracy)
        {
            double acc = Math.Pow(10, accuracy);
            double adjusted = Adjuster(Math.Pow(Math.E, x), acc);

            var sum = 0.0;
            int i = 0;
            while (adjusted != Adjuster(sum, acc))
            {
                var r = Math.Pow(x, i) / Helper.Factorial(i);
                sum += r;
                ++i;

                if (i > 20)
                    throw new NotSupportedException();
            }
            return sum;
        }
    }
}

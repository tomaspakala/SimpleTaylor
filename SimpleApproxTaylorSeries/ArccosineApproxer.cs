using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleApproxTaylorSeries
{
    public static partial class TaylorApproxer
    {
        public static double Arccosinus(double x, int accuracy)
        {
            var lastSum = Double.MaxValue;

            var sum = 0.0;
            int i = 0;
            sum = Arcsinus(x, accuracy);

            return 0.5 * Math.PI - sum;
        }
    }
}

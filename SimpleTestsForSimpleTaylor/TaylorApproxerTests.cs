using System;
using NUnit.Framework;
using SimpleApproxTaylorSeries;

namespace SimpleTestForSimpleTaylor
{
    [TestFixture]
    public class TaylorApproxerTests
    {
        [TestCase (3, 0.5, 4)]
        [TestCase (3, 0.5, 8)]
        public void Power(double x, double power, int accuracy)
        {
            double accuracity = Math.Pow(10, accuracy + 1);

            var res = TaylorApproxer.Power(x, power, accuracy);
            
            Equals(Math.Truncate(accuracity * x) / accuracity, res);
        }
    }
}

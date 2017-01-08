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
        [TestCase (31, 0.2, 5)]
        public void Power(double x, double power, int accuracy)
        {
            double accuracity = Math.Pow(10, accuracy + 1);

            var res = TaylorApproxer.Power(x, power, accuracy);

            
            Assert.AreEqual(Math.Truncate(accuracity * Math.Pow(x, power)) / accuracity,
                Math.Truncate(accuracity * res) / accuracity);
        }
    }
}

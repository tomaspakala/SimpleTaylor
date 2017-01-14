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
            Console.WriteLine(res);
        }

        [TestCase(3, 0.5, 4)]
        [TestCase(3, 0.5, 8)]
        [TestCase(31, 0.2, 5)]
        public void Exponential(double x, double power, int accuracy)
        {
            double accuracity = Math.Pow(10, accuracy + 1);

            var res = TaylorApproxer.Exponential(x, power, accuracy);

            Assert.AreEqual(Math.Truncate(accuracity * Math.Pow(x, power)) / accuracity,
                Math.Truncate(accuracity * res) / accuracity);
            Console.WriteLine(res);
        }

        [TestCase(1, 8)]
        public void Sinus(double x, int accuracy)
        {
            double accuracity = Math.Pow(10, accuracy + 1);

            var res = TaylorApproxer.Sine(x, accuracy);

            Assert.AreEqual(Math.Truncate(accuracity * Math.Sin(Helper.DegreeToRadian(x))) / accuracity,
                Math.Truncate(accuracity * res) / accuracity);
            Console.WriteLine(res);
        }

        [TestCase(1, 8)]
        public void Cosine(double x, int accuracy)
        {
            double accuracity = Math.Pow(10, accuracy + 1);

            var res = TaylorApproxer.Cosine(x, accuracy);

            Assert.AreEqual(Math.Truncate(accuracity * Math.Cos(Helper.DegreeToRadian(x))) / accuracity,
                Math.Truncate(accuracity * res) / accuracity);
            Console.WriteLine(res);
        }

        [TestCase(0.5, 4)]
        [TestCase(0.5, 8)]
        [TestCase(0.2, 5)]
        public void EExponential(double power, int accuracy)
        {
            double accuracity = Math.Pow(10, accuracy + 1);

            var res = TaylorApproxer.EExponential(power, accuracy);

            Assert.AreEqual(Math.Truncate(accuracity * Math.Pow(Math.E, power)) / accuracity,
                Math.Truncate(accuracity * res) / accuracity);
            Console.WriteLine(res);
        }

        [TestCase(10)]
        [TestCase(100)]
        public void Pi(int digits)
        {
            var res = HighPrecisionPi.GetPi(digits);
            Console.WriteLine(res);
        }
    }
}

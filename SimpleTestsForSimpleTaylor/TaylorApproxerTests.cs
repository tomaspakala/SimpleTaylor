using System;
using NUnit.Framework;
using SimpleApproxTaylorSeries;

namespace SimpleTestForSimpleTaylor
{
    [TestFixture]
    public class TaylorApproxerTests
    {
        [TestCase (5, 0.5, 4)]
        [TestCase (3, 0.5, 8)]
        [TestCase (33, 0.2, 5)]
        public void Power(double x, double power, int accuracy)
        {
            double accuracity = Math.Pow(10, accuracy);

            var res = TaylorApproxer.Power(x, power, accuracy);
            
            Assert.AreEqual(Math.Truncate(accuracity * Math.Pow(x, power)) / accuracity,
                Math.Truncate(accuracity * res) / accuracity);
        }

        [TestCase(3, 0.5, 4)]
        [TestCase(3, 0.5, 8)]
        [TestCase(31, 0.2, 5)]
        public void Exponential(double x, double power, int accuracy)
        {
            double accuracity = Math.Pow(10, accuracy);

            var res = TaylorApproxer.Exponential(x, power, accuracy);

            Assert.AreEqual(Math.Truncate(accuracity * Math.Pow(x, power)) / accuracity,
                Math.Truncate(accuracity * res) / accuracity);
        }

        [TestCase(1, 8)]
        public void Sine(double x, int accuracy)
        {
            double accuracity = Math.Pow(10, accuracy);

            var res = TaylorApproxer.Sine(x, accuracy);

            Assert.AreEqual(Math.Truncate(accuracity * Math.Sin(Helper.DegreeToRadian(x))) / accuracity,
                Math.Truncate(accuracity * res) / accuracity);
        }

        [TestCase(1, 8)]
        public void Cosine(double x, int accuracy)
        {
            double accuracity = Math.Pow(10, accuracy);

            var res = TaylorApproxer.Cosine(x, accuracy);

            Assert.AreEqual(Math.Truncate(accuracity * Math.Cos(Helper.DegreeToRadian(x))) / accuracity,
                Math.Truncate(accuracity * res) / accuracity);
        }

        [TestCase(1, 8)]
        public void Tangent(double x, int accuracy)
        {
            double accuracity = Math.Pow(10, accuracy);

            var res = TaylorApproxer.Tangent(x, accuracy);

            Assert.AreEqual(Math.Truncate(accuracity * Math.Tan(Helper.DegreeToRadian(x))) / accuracity,
                Math.Truncate(accuracity * res) / accuracity);
        }

        [TestCase(1, 8)]
        [TestCase(90, 8)]
        public void SineHyper(double x, int accuracy)
        {
            double accuracity = Math.Pow(10, accuracy);

            var res = TaylorApproxer.SineHyper(x, accuracy);

            Assert.AreEqual(Math.Truncate(accuracity * Math.Sinh(Helper.DegreeToRadian(x))) / accuracity,
                Math.Truncate(accuracity * res) / accuracity);
        }

        [TestCase(1, 8)]
        [TestCase(180, 8)]
        public void CosineHyper(double x, int accuracy)
        {
            double accuracity = Math.Pow(10, accuracy);

            var res = TaylorApproxer.CosineHyper(x, accuracy);

            Assert.AreEqual(Math.Truncate(accuracity * Math.Cosh(Helper.DegreeToRadian(x))) / accuracity,
                Math.Truncate(accuracity * res) / accuracity);
        }

        [TestCase(2.0, 4)]
        [TestCase(0.5, 8)]
        [TestCase(0.2, 5)]
        [TestCase(1.0, 5)]
        public void EExponential(double power, int accuracy)
        {
            double accuracity = Math.Pow(10, accuracy);

            var res = TaylorApproxer.EExponential(power, accuracy);

            Assert.AreEqual(Math.Truncate(accuracity * Math.Pow(Math.E, power)) / accuracity,
                Math.Truncate(accuracity * res) / accuracity);
            Console.WriteLine(res);
        }

        [TestCase(0.5, 4)]
        [TestCase(0.5, 8)]
        [TestCase(0.2, 5)]
        [TestCase(1.0, 5)]
        [TestCase(5.0, 5)]
        public void Logarithm(double x, int accuracy)
        {
            double accuracity = Math.Pow(10, accuracy);

            var res = TaylorApproxer.Logarithm(x, accuracy);

            Assert.AreEqual(Math.Truncate(accuracity * Math.Log(x)) / accuracity,
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

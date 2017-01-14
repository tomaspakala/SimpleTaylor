using System;
using System.Numerics;
using System.Text;

namespace SimpleApproxTaylorSeries
{
    public class HighPrecisionPi
    {
        private static BigInteger denom;
        private static int precision;
        private static int slop = 4;
        private BigInteger num;

        public HighPrecisionPi(BigInteger numerator, BigInteger denominator)
        {
            // public constructor rescales numerator as needed
            num = denom * numerator / denominator;
        }

        private HighPrecisionPi(BigInteger numerator)
        {
            // private constructor for when we already know the scaling
            num = numerator;
        }

        public static int Precision
        {
            get { return precision; }
            set
            {
                precision = value;
                denom = BigInteger.Pow(10, precision + slop); // leave some buffer
            }
        }

        public bool IsZero => num.IsZero;

        public BigInteger Numerator => num;

        public BigInteger Denominator => denom;

        public static HighPrecisionPi operator *(int left, HighPrecisionPi right)
        {
            // no need to resale when multiplying by an int
            return new HighPrecisionPi(right.num * left);
        }

        public static HighPrecisionPi operator *(HighPrecisionPi left, HighPrecisionPi right)
        {
            // a/D * b/D = ab/D^2 = (ab/D)/D
            return new HighPrecisionPi((left.num * right.num) / denom);
        }

        public static HighPrecisionPi operator /(HighPrecisionPi left, int right)
        {
            // no need to rescale when dividing by an int
            return new HighPrecisionPi(left.num / right);
        }

        public static HighPrecisionPi operator +(HighPrecisionPi left, HighPrecisionPi right)
        {
            // when we know the denominators are the same, can just add the numerators
            return new HighPrecisionPi(left.num + right.num);
        }

        public static HighPrecisionPi operator -(HighPrecisionPi left, HighPrecisionPi right)
        {
            // when we know the denominators are the same, can just subtract the numerators
            return new HighPrecisionPi(left.num - right.num);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            // pull out the integer part
            BigInteger remain;
            BigInteger quotient = BigInteger.DivRem(num, denom, out remain);
            int integerDigits = quotient.IsZero ? 1 : (int) BigInteger.Log10(quotient) + 1;
            sb.Append(quotient);

            int i = 0;
            BigInteger smallDenom = denom / 10;
            BigInteger tempRemain;

            // pull out all of the 0s after the decimal point
            while (i++ < Precision && (quotient = BigInteger.DivRem(remain, smallDenom, out tempRemain)).IsZero)
            {
                smallDenom /= 10;
                remain = tempRemain;
                sb.Append('0');
            }

            // append the rest of the remainder
            sb.Append(remain);

            // truncate and insert the decimal point
            return sb.ToString().Remove(integerDigits + Precision).Insert(integerDigits, ".");
        }

        public static HighPrecisionPi GetPi(int digits)
        {
            Precision = digits;
            HighPrecisionPi first = 4 * Atan(5);
            HighPrecisionPi second = Atan(239);
            return 4 * (first - second);
        }

        public static HighPrecisionPi Atan(int denominator)
        {
            HighPrecisionPi result = new HighPrecisionPi(1, denominator);
            int xSquared = denominator * denominator;

            int divisor = 1;
            HighPrecisionPi term = result;

            while (!term.IsZero)
            {
                divisor += 2;
                term /= xSquared;
                result -= term / divisor;

                divisor += 2;
                term /= xSquared;
                result += term / divisor;
            }

            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fraction
{
    partial class Fraction
    {
        private int GCD()
        {
            int a = _numerator;
            int b = _denominator;

            while (a != b)
            {
                if (a > b)
                    a -= b;

                else
                    b -= a;
            }

            return a;
        }

        public void Normalize()
        {
            int gcd = GCD();

            _numerator /= gcd;
            _denominator /= gcd;
        }

        public double Value()
        {
            return ((double)_numerator) / _denominator;
        }
    }
}

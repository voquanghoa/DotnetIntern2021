using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetIntern2021.OOP
{
    public class Fraction
    {
        //Exercise 1
        public int A { get; private set; }
        public int B { get; private set; }
        public Fraction(int numerator, int denominator)
        {
            if (denominator == 0)
            {
                throw new ArgumentException("Denominator cannot be zero");
            }
            A = numerator;
            B = denominator;
        }
        public static int GCD(int a, int b)
        {
            while (a != b)
            {
                if (a > b)
                {
                    a -= b;
                }
                else
                {
                    b -= a;
                }
            }
            return a;
        }
        //Exercise 2
        public static bool operator ==(Fraction a, Fraction b)
        {
            return a.A * b.B == a.B * b.A;
        }

        public static bool operator !=(Fraction a, Fraction b)
        {
            return !(a == b);
        }
        public override bool Equals(object obj)
        {
            if (obj is Fraction fraction)
            {
                return this == fraction;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return $"{A}/{B}".GetHashCode();
        }

        public override string ToString()
        {
            return $"{A}/{B}".ToString();
        }

        //Exercise 3
        public Fraction Minimal()
        {
            int gcd = GCD(Math.Abs(A), Math.Abs(B));

            return new Fraction(A / gcd, B / gcd);
        }

        //Exercise 4
        public static Fraction operator +(Fraction a)
        {
            return a;
        }

        public static Fraction operator -(Fraction a)
        {
            return new Fraction(-a.A, a.B);
        }

        public static Fraction operator +(Fraction a, Fraction b)
        {
            return new Fraction(a.A * b.B + b.A * a.B, a.B * b.B).Minimal();
        }

        public static Fraction operator -(Fraction a, Fraction b)
        {
            return a + (-b);
        }

        public static Fraction operator *(Fraction a, Fraction b)
        {
            return (new Fraction(a.A * b.A, a.B * b.B)).Minimal();
        }

        public static Fraction operator /(Fraction a, Fraction b)
        {
            return (new Fraction(a.A * b.B, a.B * b.A)).Minimal();
        }

        //Exercise 5
        public static bool operator >(Fraction a, Fraction b)
        {
            return a.A * b.B > b.A * a.B;
        }

        public static bool operator <(Fraction a, Fraction b)
        {
            return a.A * b.B < b.A * a.B;
        }
        public static bool operator >=(Fraction a, Fraction b)
        {
            return a.A * b.B >= b.A * a.B;
        }
        public static bool operator <=(Fraction a, Fraction b)
        {
            return a.A * b.B <= b.A * a.B;
        }

        //Exercise 6
        public static Fraction operator !(Fraction a)
        {
            return new Fraction(a.B, a.A);
        }

        //Exercise 7
        public static explicit operator Fraction(int integer) => new Fraction(integer, 1);

        //Exercise 8
        public static implicit operator float(Fraction fraction) => (float)fraction.A/ (float)fraction.B;

        //Exercise 9
        public static Fraction operator +(Fraction fraction, int integer)
        {
            return (new Fraction(fraction.A + integer * fraction.B, fraction.B)).Minimal();
        }

        public static Fraction operator -(Fraction fraction, int integer)
        {
            return fraction + (-integer);
        }

        public static Fraction operator *(Fraction fraction, int integer)
        {
            return (new Fraction(fraction.A * integer, fraction.B)).Minimal();
        }

        public static Fraction operator /(Fraction fraction, int integer)
        {
            if (integer == 0)
            {
                throw new DivideByZeroException();
            }
            return (new Fraction(fraction.A, fraction.B * integer)).Minimal();
        }
    }
}

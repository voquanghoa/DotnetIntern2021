using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetIntern2021.OOP
{
    class Fraction
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
        //Exercise 2
        public static bool operator ==(Fraction a, Fraction b)
        {
            a = Minimal(a);
            b = Minimal(b);
            return (a.A == b.A && a.B == b.B);
        }

        public static bool operator !=(Fraction a, Fraction b)
        {
            a = Minimal(a);
            b = Minimal(b);
            return (a.A != b.A || a.B != b.B);
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
        public static Fraction Minimal(Fraction fraction)
        {
            Fraction answer = new Fraction(fraction.A, fraction.B);
            fraction = new Fraction(Math.Abs(fraction.A), Math.Abs(fraction.B));
            while (fraction.A != fraction.B)
            {
                if (fraction.A > fraction.B)
                {
                    fraction.A -= fraction.B;
                }
                else
                {
                    fraction.B -= fraction.A;
                }
            }

            answer.A = answer.A / fraction.A;
            answer.B = answer.B / fraction.B;

            return answer;
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
            var denominatorArray = new int[2]
            {
                a.B, b.B
            };
            while (denominatorArray[0] != denominatorArray[1])
            {
                if (denominatorArray[0] > denominatorArray[1])
                {
                    denominatorArray[0] -= denominatorArray[1];
                }
                else
                {
                    denominatorArray[1] -= denominatorArray[0];
                }
            }
            int lcm = a.B * b.B / denominatorArray[0];
            return Minimal(new Fraction(a.A * lcm / (a.B) + b.A * lcm / (b.B), lcm));
        }

        public static Fraction operator -(Fraction a, Fraction b)
        {
            return a + (-b);
        }

        public static Fraction operator *(Fraction a, Fraction b)
        {
            return Minimal(new Fraction(a.A * b.A, a.B * b.B));
        }

        public static Fraction operator /(Fraction a, Fraction b)
        {
            return Minimal(new Fraction(a.A * b.B, a.B * b.A));
        }

        //Exercise 5
        public static bool operator >(Fraction a, Fraction b)
        {
            a = Minimal(a);
            b = Minimal(b);
            return a.A * b.B > b.A * a.B;
        }

        public static bool operator <(Fraction a, Fraction b)
        {
            a = Minimal(a);
            b = Minimal(b);
            return a.A * b.B < b.A * a.B;
        }
        public static bool operator >=(Fraction a, Fraction b)
        {
            a = Minimal(a);
            b = Minimal(b);
            return a.A * b.B >= b.A * a.B;
        }
        public static bool operator <=(Fraction a, Fraction b)
        {
            a = Minimal(a);
            b = Minimal(b);
            return a.A * b.B <= b.A * a.B;
        }

        //Exercise 6
        public static Fraction operator !(Fraction a)
        {
            return new Fraction(a.B, a.A);
        }

        //Exercise 7
        public static Fraction IntegerToFraction(int integer)
        {
            return new Fraction(integer, 1);
        }

        //Exercise 8
        public float FractionToRealNumber()
        {
            return (float)A / B;
        }

        //Exercise 9
        public static Fraction operator +(Fraction fraction, int integer)
        {
            return Minimal(new Fraction(fraction.A + integer * fraction.B, fraction.B));
        }

        public static Fraction operator -(Fraction fraction, int integer)
        {
            return fraction + (-integer);
        }

        public static Fraction operator *(Fraction fraction, int integer)
        {
            return Minimal(new Fraction(fraction.A * integer, fraction.B));
        }

        public static Fraction operator /(Fraction fraction, int integer)
        {
            if (integer == 0)
            {
                throw new DivideByZeroException();
            }
            return Minimal(new Fraction(fraction.A, fraction.B * integer));
        }
    }
}

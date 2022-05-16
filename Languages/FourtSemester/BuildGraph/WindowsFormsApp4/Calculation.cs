using System;
using System.Collections.Generic;
using System.Numerics;

namespace WindowsFormsApp4
{
    public static class Calculation
    {
        public static double Discriminant(double a, double b, double c) => Math.Pow(b, 2) - 4 * a * c;

        public static IEnumerable<Complex> EquationOfTheSecondDegree(double a0, double a1, double a2)
        {
            double disc = a1 * a1 - 4 * a0 * a2;
            if (disc < 1E-14 && disc > -1E-14)
                disc = 0;
            if (disc < 0)
            {
                double bufer = Math.Sqrt(-disc) / 2 / a0;
                if (bufer < 1E-9 && bufer > -1E-9)
                    bufer = 0;
                return new List<Complex> { new Complex(-a1 / 2 / a0, bufer), new Complex(-a1 / 2 / a0, -bufer) };
            }
            else
            {
                return new List<Complex> { new Complex((-a1 - Math.Sqrt(disc)) / 2 / a0, 0), new Complex((-a1 + Math.Sqrt(disc)) / 2 / a0, 0) };
            }
        }

        public static IEnumerable<Complex> EquationOfTheThirdDegree(double a0, double a1, double a2, double a3) 
        {
            double a = a1 / a0, b = a2 / a0, c = a3 / a0;
            double q = Math.Pow(a, 2) - 3 * b;
            double r = 2 * Math.Pow(a, 3) - 9 * a * b + 27 * c;
            if (Math.Pow(r, 2) / 2916 < Math.Pow(q, 3) / 729)
            {
                double t = Math.Acos(r / Math.Sqrt(Math.Pow(q, 3)) / 2) / 3;
                double x1 = -2 * Math.Sqrt(q) / 3 * Math.Cos(t) - a / 3;
                double x2 = -2 * Math.Sqrt(q) / 3 * Math.Cos(t + (2 * Math.PI / 3)) - a / 3;
                double x3 = -2 * Math.Sqrt(q) / 3 * Math.Cos(t - (2 * Math.PI / 3)) - a / 3;
                return new List<Complex> { x1, x2, x3 };
            }
            else
            {
                double A = -Math.Sign(r) * Math.Pow(3 * Math.Abs(r) + Math.Sqrt(9 * Math.Pow(r, 2) - 36 * Math.Pow(q, 3)), (double)1 / 3) / 3 / Math.Pow(6, (double)1 / 3);
                double B = (A == 0) ? 0 : q / A / 9;
                double x1 = (A + B) - a / 3;
                if (A - B < 1E-14 && A - B > -1E-14)
                {
                    double x2 = -A - a / 3;
                    return new List<Complex> { x1, x2 };
                }
                else
                {
                    Complex x2 = new Complex(-(A + B) / 2 - (a / 3), Math.Sqrt(3) * (A - B) / 2);
                    Complex x3 = new Complex(-(A + B) / 2 - (a / 3), -Math.Sqrt(3) * (A - B) / 2);
                    return new List<Complex> { x1, x2, x3 };
                }
            }
        }
        public static IEnumerable<Complex> FindingRootsOfHigherDegree(double a, double b, double c, double d, double e, double f)
        {
            int startCalc = -100, endCalc = 100;
            double step = 0.01;
            Complex num;
            List<Complex> listResult = new List<Complex>();
            for (double i = startCalc; i <= endCalc; i += step)
            {
                i = Math.Round(i, 2);
                num = Math.Pow(i, 5) * a + Math.Pow(i, 4) * b + Math.Pow(i, 3) * c + Math.Pow(i, 2) * d + i * e + f;
                if (num == 0)
                {
                    listResult.Add(i);
                }
            }
            return listResult;
        }
    }
}
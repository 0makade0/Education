        using System;
using System.Collections.Generic;
using System.Numerics;

namespace WindowsFormsApp4
{
    public static class Calculation
    {
        public static double Discriminant(double a, double b, double c) => Math.Pow(b, 2) - 4 * a * c;

        public static double[] EquationOfTheSecondDegree(double a, double b, double c)
        {
            double[] result = new double[2];
            if (b == 0)
            {
                result[0] = -Math.Sqrt((-1 * c) / a);
                result[1] = Math.Sqrt((-1 * c) / a);
            }
            else
            {
                double discr = Discriminant(a, b, c);
                result[0] = (-b - Math.Sqrt(discr)) / (2 * a);
                result[1] = (-b + Math.Sqrt(discr)) / (2 * a);
            }

            return result;
        }

        public static IEnumerable<Complex> EquationOfTheThirdDegree(double a0, double a1, double a2, double a3)
        {
            double a = a1 / a0, b = a2 / a0, c = a3 / a0;
            double q = (a * a - 3 * b) / 9;
            double r = (2 * a * a * a - 9 * a * b + 27 * c) / 54;
            double s = q * q * q - r * r;
            double arg;
            if (s > 0)
            {
                arg = Math.Acos(r / Math.Sqrt(Math.Pow(q, 3))) / 3;
                double x1 = -2 * Math.Sqrt(q) * Math.Cos(arg) - a / 3;
                double x2 = -2 * Math.Sqrt(q) * Math.Cos(arg + 2 * Math.PI / 3) - a / 3;
                double x3 = -2 * Math.Sqrt(q) * Math.Cos(arg - 2 * Math.PI / 3) - a / 3;
                return new List<Complex>
                {
                    new Complex(x1, 0), new Complex(x2, 0), new Complex(x3, 0)
                };
            }
            else
                if (s < 0)
            {
                double t = Math.Abs(r) / Math.Sqrt(Math.Pow(q, 3));
                arg = Math.Log(t + Math.Sqrt(t * t + 1)) / 3;
                double x1 = -2 * Math.Sign(r) * Math.Sqrt(Math.Abs(q)) * (Math.Exp(arg) + Math.Exp(-arg)) / 2 - a / 3;
                Complex x2 = new Complex(Math.Sign(r) * Math.Sqrt(Math.Abs(q)) * (Math.Exp(arg) + Math.Exp(-arg)) / 2 - a / 3, Math.Sqrt(3 * Math.Abs(q)) * (Math.Exp(arg) - Math.Exp(-arg)) / 2);
                Complex x3 = new Complex(Math.Sign(r) * Math.Sqrt(Math.Abs(q)) * (Math.Exp(arg) + Math.Exp(-arg)) / 2 - a / 3, -Math.Sqrt(3 * Math.Abs(q)) * (Math.Exp(arg) - Math.Exp(-arg)) / 2);
                return new List<Complex>
                {
                    new Complex(x1, 0), x2, x3
                };
            }
            else
            {
                double x1 = -2 * Math.Pow(r, 1 / 3) - a / 3;
                double x2 = Math.Pow(r, 1 / 3) - a / 3;
                double x3 = x2;
                return new List<Complex>
                {
                    new Complex(x1, 0), new Complex(x2, 0), new Complex(x3, 0)
                };
            }
        }
       

        public static List<string> EquationOfTheFourthDegree(double a, double b, double c, double d, double e)
        {
            List<string> result = new List<string>();

            b = b / a;
            c = c / a;
            d = d / a;
            e = e / a;
            a = 1;


            var p = (8 * c - 3 * Math.Pow(b, 2)) / 8;
            var q = (8 * d + Math.Pow(b, 3) - 4 * b * c) / 8;
            var r = (16 * Math.Pow(b, 2) * c - 64 * b * d - 3 * Math.Pow(b, 4) + 256 * e) / 256;
            var b1 = 2 * p;
            var c1 = Math.Pow(p, 2) - 4 * r;
            var d1 = -Math.Pow(q, 2);
            var p1 = (3 * c1 - Math.Pow(b1, 2)) / 3;
            var q1 = (2 * Math.Pow(b1, 3) - 9 * b1 * c1 + 27 * d1) / 27;
            var Q = Math.Pow(p1 / 3, 3) + Math.Pow(q1 / 2, 2);
            Complex QQ, U, V, e1, e2, x1, x2, x3, y1, y2, y3, y4, pp1 = 0, pp2 = 0, pp3 = 0, pp4 = 0;
            Complex z1, z2, z3, j;

            j = Complex.ImaginaryOne;
            if (Q < 0)
            {
                double x11, x22, x33;
                e1 = new Complex(-0.5, Math.Sqrt(3) / 2);
                e2 = Complex.Conjugate(e1);
                QQ = Complex.Sqrt(Q);
                var del = q1 / 2;
                U = Complex.Pow(QQ - del, 1 / 3.0);
                V = Complex.Conjugate(U);
                z1 = U + V;
                z2 = e1 * U + e2 * V;
                z3 = e2 * U + e1 * V;
                x11 = z1.Real - b1 / 3;
                x22 = z2.Real - b1 / 3;
                x33 = z3.Real - b1 / 3;
                x1 = Complex.Sqrt(x11);
                x2 = Complex.Sqrt(x22);
                x3 = Complex.Sqrt(x33);
                if ((x1 * x2 * x3).Real < 0 | q < 0) { x1 = -x1; }
                if ((x1 * x2 * x3).Real > 0 | q > 0) { x1 = -x1; }
                y1 = 0.5 * (x1 + x2 + x3);
                y2 = 0.5 * (x1 - x2 - x3);
                y3 = 0.5 * (-x1 + x2 - x3);
                y4 = 0.5 * (-x1 - x2 + x3);
                pp1 = y1 - b / 4;
                pp2 = y2 - b / 4;
                pp3 = y3 - b / 4;
                pp4 = y4 - b / 4;
            }
            if (Q > 0)
            {
                Complex x11, x22, x33;
                U = -q1 / 2;
                V = Complex.Sqrt(Q);
                z1 = Complex.Pow(((U) + V), 1 / 3.0) + Complex.Pow((U - V), 1 / 3.0);
                z2 = -0.5 * (Complex.Pow((U + V), 1 / 3.0) + Complex.Pow((U - V), 1 / 3.0)) + j * Math.Sqrt(3) * 0.5 * (Complex.Pow((U + V), 0.3333333333333) - Complex.Pow((U - V), 0.3333333333333333));
                z3 = Complex.Conjugate(z2);
                x11 = z1 - b1 / 3;
                x22 = z2 - b1 / 3;
                x33 = z3 - b1 / 3;
                x1 = Complex.Sqrt(x11);
                x2 = Complex.Sqrt(x22);
                x3 = Complex.Sqrt(x33);
                if ((x1 * x2 * x3).Real < 0 | q < 0) { x1 = -x1; }
                if ((x1 * x2 * x3).Real > 0 | q > 0) { x1 = -x1; }
                y1 = 0.5 * (x1 + x2 + x3);
                y2 = 0.5 * (x1 - x2 - x3);
                y3 = 0.5 * (-x1 + x2 - x3);
                y4 = 0.5 * (-x1 - x2 + x3);
                pp1 = y1 - b / 4;
                pp2 = y2 - b / 4;
                pp3 = y3 - b / 4;
                pp4 = y4 - b / 4;
            }
            if (Q == 0)
            {
                double x11, x22, x33;
                z1 = -Math.Pow(-(q / 2), 1 / 3.0);
                z2 = 2 * Math.Pow(-(q / 2), 1 / 3.0);
                x11 = z1.Real - b1 / 3;
                x22 = z2.Real - b1 / 3;
                x33 = 0;
                x1 = Complex.Sqrt(x11);
                x2 = Complex.Sqrt(x22);
                x3 = Complex.Sqrt(x33);
                if ((x1 * x2 * x3).Real < 0 | q < 0) { x1 = -x1; }
                if ((x1 * x2 * x3).Real > 0 | q > 0) { x1 = -x1; }
                y1 = 0.5 * (x1 + x2 + x3);
                y2 = 0.5 * (x1 - x2 - x3);
                y3 = 0.5 * (-x1 + x2 - x3);
                y4 = 0.5 * (-x1 - x2 + x3);
                pp1 = y1 - b / 4;
                pp2 = y2 - b / 4;
                pp3 = y3 - b / 4;
                pp4 = y4 - b / 4;
            }

            result.Add(Convert.ToString(Math.Round(pp1.Real, 5)) + "+i(" + Convert.ToString(Math.Round(pp1.Imaginary, 5)) + ")");
            result.Add(Convert.ToString(Math.Round(pp2.Real, 5)) + "+i(" + Convert.ToString(Math.Round(pp2.Imaginary, 5)) + ")");
            result.Add(Convert.ToString(Math.Round(pp3.Real, 5)) + "+i(" + Convert.ToString(Math.Round(pp3.Imaginary, 5)) + ")");
            result.Add(Convert.ToString(Math.Round(pp4.Real, 5)) + "+i(" + Convert.ToString(Math.Round(pp4.Imaginary, 5)) + ")");
            return result;
        }

        public static List<string> EquationOfTheFifthDegree(double a, double b, double c, double d, double e, double f)
        {
            List<string> result = new List<string>();

            b = b / a;
            c = c / a;
            d = d / a;
            e = e / a;
            f = f / a;
            a = 1;


            var p = (8 * c - 3 * Math.Pow(b, 2)) / 8;
            var q = (8 * d + Math.Pow(b, 3) - 4 * b * c) / 8;
            var r = (16 * Math.Pow(b, 2) * c - 64 * b * d - 3 * Math.Pow(b, 4) + 256 * e) / 256;
            var b1 = 2 * p;
            var c1 = Math.Pow(p, 2) - 4 * r;
            var d1 = -Math.Pow(q, 2);
            var p1 = (3 * c1 - Math.Pow(b1, 2)) / 3;
            var q1 = (2 * Math.Pow(b1, 3) - 9 * b1 * c1 + 27 * d1) / 27;
            var Q = Math.Pow(p1 / 3, 3) + Math.Pow(q1 / 2, 2);
            Complex QQ, U, V, e1, e2, e3, x1, x2, x3, x4, y1, y2, y3, y4, y5, pp1 = 0, pp2 = 0, pp3 = 0, pp4 = 0, pp5 = 0;
            Complex z1, z2, z3, z4, j;

            j = Complex.ImaginaryOne;
            if (Q < 0)
            {
                double x11, x22, x33, x44;
                e1 = new Complex(-0.5, Math.Sqrt(3) / 2);
                e2 = Complex.Conjugate(e1);
                e3 = Complex.Conjugate(e2);
                QQ = Complex.Sqrt(Q);
                var del = q1 / 2;
                U = Complex.Pow(QQ - del, 1 / 3.0);
                V = Complex.Conjugate(U);
                z1 = U + V;
                z2 = e1 * U + e2 * V;
                z3 = e2 * U + e1 * V;
                z4 = e3 * U + e3 * V;
                x11 = z1.Real - b1 / 3;
                x22 = z2.Real - b1 / 3;
                x33 = z3.Real - b1 / 3;
                x44 = z4.Real - b1 / 3;
                x1 = Complex.Sqrt(x11);
                x2 = Complex.Sqrt(x22);
                x3 = Complex.Sqrt(x33);
                x4 = Complex.Sqrt(x44);
                if ((x1 * x2 * x3 * x4).Real < 0 | q < 0) { x1 = -x1; }
                if ((x1 * x2 * x3).Real > 0 | q > 0) { x1 = -x1; }
                y1 = 0.5 * (x1 + x2 + x3 + x4);
                y2 = 0.5 * (x1 - x2 - x3 - x4);
                y3 = 0.5 * (-x1 + x2 - x3 - x4);
                y4 = 0.5 * (-x1 - x2 + x3 + x4);
                y5 = 0.5 * (-x1 + x2 + x3 - x4);
                pp1 = y1 - b / 4;
                pp2 = y2 - b / 4;
                pp3 = y3 - b / 4;
                pp4 = y4 - b / 4;
                pp5 = y5 - b / 4;
            }
            if (Q > 0)
            {
                Complex x11, x22, x33, x44;
                U = -q1 / 2;
                V = Complex.Sqrt(Q);
                z1 = Complex.Pow(((U) + V), 1 / 3.0) + Complex.Pow((U - V), 1 / 3.0);
                z2 = -0.5 * (Complex.Pow((U + V), 1 / 3.0) + Complex.Pow((U - V), 1 / 3.0)) + j * Math.Sqrt(3) * 0.5 * (Complex.Pow((U + V), 0.3333333333333) - Complex.Pow((U - V), 0.3333333333333333));
                z3 = Complex.Conjugate(z2);
                z4 = Complex.Conjugate(z3);
                x11 = z1 - b1 / 3;
                x22 = z2 - b1 / 3;
                x33 = z3 - b1 / 3;
                x44 = z4 - b1 / 3;
                x1 = Complex.Sqrt(x11);
                x2 = Complex.Sqrt(x22);
                x3 = Complex.Sqrt(x33);
                x4 = Complex.Sqrt(x44);
                if ((x1 * x2 * x3 * x4).Real < 0 | q < 0) { x1 = -x1; }
                if ((x1 * x2 * x3 * x4).Real > 0 | q > 0) { x1 = -x1; }
                y1 = 0.5 * (x1 + x2 + x3 + x4);
                y2 = 0.5 * (x1 - x2 - x3 - x4);
                y3 = 0.5 * (-x1 + x2 - x3 - x4);
                y4 = 0.5 * (-x1 - x2 + x3 + x4);
                y5 = 0.5 * (-x1 + x2 + x3 - x4);
                pp1 = y1 - b / 4;
                pp2 = y2 - b / 4;
                pp3 = y3 - b / 4;
                pp4 = y4 - b / 4;
                pp5 = y5 - b / 4;
            }
            if (Q == 0)
            {
                double x11, x22, x33, x44;
                z1 = -Math.Pow(-(q / 2), 1 / 3.0);
                z2 = 2 * Math.Pow(-(q / 2), 1 / 3.0);
                x11 = z1.Real - b1 / 3;
                x22 = z2.Real - b1 / 3;
                x33 = 0;
                x44 = 0;
                x1 = Complex.Sqrt(x11);
                x2 = Complex.Sqrt(x22);
                x3 = Complex.Sqrt(x33);
                x4 = Complex.Sqrt(x44);
                if ((x1 * x2 * x3 * x4).Real < 0 | q < 0) { x1 = -x1; }
                if ((x1 * x2 * x3 * x4).Real > 0 | q > 0) { x1 = -x1; }
                y1 = 0.5 * (x1 + x2 + x3 + x4);
                y2 = 0.5 * (x1 - x2 - x3 - x4);
                y3 = 0.5 * (-x1 + x2 - x3 - x4);
                y4 = 0.5 * (-x1 - x2 + x3 + x4);
                y5 = 0.5 * (-x1 + x2 + x3 - x4);
                pp1 = y1 - b / 4;
                pp2 = y2 - b / 4;
                pp3 = y3 - b / 4;
                pp4 = y4 - b / 4;
                pp5 = y5 - b / 4;
            }
            result.Add(Convert.ToString(Math.Round(pp1.Real, 5)) + "+i(" + Convert.ToString(Math.Round(pp1.Imaginary, 5)) + ")");
            result.Add(Convert.ToString(Math.Round(pp2.Real, 5)) + "+i(" + Convert.ToString(Math.Round(pp2.Imaginary, 5)) + ")");
            result.Add(Convert.ToString(Math.Round(pp3.Real, 5)) + "+i(" + Convert.ToString(Math.Round(pp3.Imaginary, 5)) + ")");
            result.Add(Convert.ToString(Math.Round(pp4.Real, 5)) + "+i(" + Convert.ToString(Math.Round(pp4.Imaginary, 5)) + ")");
            result.Add(Convert.ToString(Math.Round(pp5.Real, 5)) + "+i(" + Convert.ToString(Math.Round(pp5.Imaginary, 5)) + ")");
            return result;
        }
    }
}

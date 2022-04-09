using System;
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

        public static double[] EquationOfTheThirdDegree(double a, double b, double c, double d)
        {
            double[] result = new double[3];

            int tip;

            double eps = 1E-14;
            double p = (3 * a * c - b * b) / (3 * a * a);
            double q = (2 * b * b * b - 9 * a * b * c + 27 * a * a * d) / (27 * a * a * a);
            double det = q * q / 4 + p * p * p / 27;
            if (Math.Abs(det) < eps)
                det = 0;
            if (det > 0)
            {
                tip = 1; // один вещественный, два комплексных корня
                double u = -q / 2 + Math.Sqrt(det);
                u = Math.Exp(Math.Log(u) / 3);
                double yy = u - p / (3 * u);
                result[0] = yy - b / (3 * a); // первый корень
                result[1] = -(u - p / (3 * u)) / 2 - b / (3 * a);
                result[2] = Math.Sqrt(3) / 2 * (u + p / (3 * u));
            }
            else
            {
                if (det < 0)
                {
                    tip = 2; // три вещественных корня
                    double fi;
                    if (Math.Abs(q) < eps) // q=0
                        fi = Math.PI / 2;
                    else
                    {
                        if (q < 0) // q<0
                            fi = Math.Atan(Math.Sqrt(-det) / (-q / 2));
                        else // q<0
                            fi = Math.Atan(Math.Sqrt(-det) / (-q / 2)) + Math.PI;
                    }
                    double r = 2 * Math.Sqrt(-p / 3);
                    result[0] = r * Math.Cos(fi / 3) - b / (3 * a);
                    result[1] = r * Math.Cos((fi + 2 * Math.PI) / 3) - b / (3 * a);
                    result[2] = r * Math.Cos((fi + 4 * Math.PI) / 3) - b / (3 * a);
                }
                else // det=0
                {
                    if (Math.Abs(q) < eps)
                    {
                        tip = 4; // 3-х кратный 
                        result[0] = -b / (3 * a); // 3-х кратный 
                        result[1] = -b / (3 * a);
                        result[2] = -b / (3 * a);
                    }
                    else
                    {
                        tip = 3; // один и два кратных
                        double u = Math.Exp(Math.Log(Math.Abs(q) / 2) / 3);
                        if (q < 0)
                            u = -u;
                        result[0] = -2 * u - b / (3 * a);
                        result[1] = u - b / (3 * a);
                        result[2] = u - b / (3 * a);
                    }
                }
            }
            return result;
        }

        public static double[] EquationOfTheFourthDegree(double a, double b, double c, double d, double e)
        {
            double[] result = new double[4];

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

            result[0] = Math.Round(pp1.Real, 5) + Math.Round(pp1.Imaginary, 5);
            result[1] = Math.Round(pp2.Real, 5) + Math.Round(pp2.Imaginary, 5);
            result[2] = Math.Round(pp3.Real, 5) + Math.Round(pp3.Imaginary, 5);
            result[3] = Math.Round(pp4.Real, 5) + Math.Round(pp4.Imaginary, 5);
            return result;
        }

        public static double[] EquationOfTheFifthDegree(double a, double b, double c, double d, double e, double f)
        {
            double[] result = new double[5];

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
            }

            result[0] = Math.Round(pp1.Real, 5) + Math.Round(pp1.Imaginary, 5);
            result[1] = Math.Round(pp2.Real, 5) + Math.Round(pp2.Imaginary, 5);
            result[2] = Math.Round(pp3.Real, 5) + Math.Round(pp3.Imaginary, 5);
            result[3] = Math.Round(pp4.Real, 5) + Math.Round(pp4.Imaginary, 5);
            result[4] = Math.Round(pp5.Real, 5) + Math.Round(pp5.Imaginary, 5);
            return result;
        }
    }
}

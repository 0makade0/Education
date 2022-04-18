﻿using System;
using System.Collections.Generic;
using System.Numerics;

namespace WindowsFormsApp4
{
    public static class Calculation
    {
        public static double Discriminant(double a, double b, double c) => Math.Pow(b, 2) - 4 * a * c;

        public static Complex[] EquationOfTheSecondDegree(double a, double b, double c)
        {
            if (a == 0)
                throw new DivideByZeroException();

            double discriminant = Math.Pow(b, 2) - 4 * a * c; // Дискриминант

            if (discriminant < 0) // Нет действительных корней
                return new Complex[0];

            return new Complex[2] { // 2 корня
                (-b + Math.Sqrt(discriminant)) / (2 * a),
                (-b - Math.Sqrt(discriminant)) / (2 * a) };
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

            public static IEnumerable<Complex> EquationOfTheFourthDegree(double a, double b, double c, double d, double e)
            {

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

        return new Complex[4] { pp1, pp2, pp3, pp4 };
    }

        public static IEnumerable<Complex> EquationOfTheFifthDegree(double a, double b, double c, double d, double e, double f)
        {

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

        return new Complex[5] { pp1, pp2, pp3, pp4,pp5 };
    }
}
}
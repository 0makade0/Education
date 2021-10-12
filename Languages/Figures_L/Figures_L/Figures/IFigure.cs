using System;

namespace Figures_L.Figures
{
    public interface IFigure
    {
        bool Verification(double side1, double side2);
        public double Perimetr(double side1,double side2);
        double Square(double side1, double side2);
        void GetInfo();
    }
}

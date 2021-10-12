using System;

namespace Figures_L.Figures
{
    public interface IFigure
    {
        public bool Verification(double side1, double side2);
        public double Perimetr(double side1,double side2);
        public double Square(double side1, double side2);
        public void GetInfo();
    }
}

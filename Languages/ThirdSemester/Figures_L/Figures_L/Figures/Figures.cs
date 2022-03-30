using System;

namespace Figures_L.Figures_L
{
    public abstract class Figure
    {
        protected Random random = new Random();
        public abstract double Area();
        public abstract double Perimeter();
        public abstract void Info();
    }
}

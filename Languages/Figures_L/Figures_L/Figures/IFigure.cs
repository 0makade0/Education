﻿namespace Figures_L.Figures_L
{
    public interface IFigure
    {
       public double Perimetr();
        //Абстрактный метод для подсчёта площади
        public double Square();
        //Вывод всей информации о фигуре
        void GetInfo();
    }
}
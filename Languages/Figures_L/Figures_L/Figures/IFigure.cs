namespace Figures_L.Figures
{
    public interface IFigure
    {
        //Проверка фигуры
        string Verification();
        public double Perimetr();
        //Абстрактный метод для подсчёта площади
        public double Square();
        //Вывод всей информации о фигуре
        void GetInfo();
    }
}
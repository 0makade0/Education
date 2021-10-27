using System;
using System.Collections.Generic;
using System.Collections;

namespace Figures_L.Figures
{
    public class Figures : IEnumerable
    {
       public  List<Figures> figures = new List<Figures>();
        public IEnumerator GetEnumerator()
        {
            return figures.GetEnumerator();
        }
        public void Addition(Figures figure)
        {
            figures.Add(figure);
        }
    }
}

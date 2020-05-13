using System;
using System.Collections.Generic;

namespace Snake
{
    public class Figure
    {
        // Список точек
        protected List<Point> pList;


        // Метод отображения
        public void Drow()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }
    }
}
 
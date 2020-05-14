using System;
using System.Collections.Generic;

namespace Snake
{
    public class Figure
    {
        // Список точек
        protected List<Point> pList;


        // Метод отображения
        public void Draw()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }

        internal bool isHit(Figure figure)
        {
            foreach (var p in pList)
            {
                if (figure.isHit(p))
                    return true;
            }
            return false;
        }

        private bool isHit(Point point)
        {
            foreach (var p in pList)
            {
                if (p.isHit(point))
                    return true;
            }
            return false;
        }
    }
}
 
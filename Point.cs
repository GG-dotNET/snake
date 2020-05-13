using System;
using System.Collections.Generic;

namespace Snake
{
    public class Point
    {
        public int x;
        public int y;
        public char sym;

        public Point(int _x, int _y, char _sym)
        {
            x = _x;
            y = _y;
            sym = _sym;
        }

        // Конструктор - задать точки с помощью другой точки
        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
        }

        // Метод сдвигает точку на расстояние
        public void Move(int offset, Direction direction)
        {
            if (direction == Direction.RIGHT)
                x = x + offset;
            else if (direction == Direction.LEFT)
                x = x - offset;
            else if (direction == Direction.DOWN)
                x = x + offset;
            else if (direction == Direction.UP)
                x = x - offset;
        }

        
        // Метод отрисовки точки
        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }


        // Метод стирает точку
        public void Clear()
        {
            sym = ' ';
            Draw();
        }

    }
}

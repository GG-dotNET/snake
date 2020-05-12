using System;
using System.Collections.Generic;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.SetWindowSize(80, 25);
            //Console.SetBufferSize(80, 25);

            // Отрисовка рамочки
            //HorizontalLine upLine = new HorizontalLine(0, 78, 0, '+');
            //HorizontalLine downLine = new HorizontalLine(0, 78, 24, '+');
            //VerticalLine leftLine = new VerticalLine(0, 24, 0, '+');
            //VerticalLine rightLine = new VerticalLine(0, 24, 78, '+');
            //upLine.Drow();
            //downLine.Drow();
            //leftLine.Drow();
            //rightLine.Drow();

            
            // Отрисовка точки
            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 10, Direction.RIGHT);


        }

        
    }
}

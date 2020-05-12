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
            HorizontalLine upLine = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine downLine = new HorizontalLine(0, 78, 24, '+');
            VerticalLine leftLine = new VerticalLine(0, 24, 0, '+');
            VerticalLine rightLine = new VerticalLine(0, 24, 78, '+');
            upLine.Drow();
            downLine.Drow();
            leftLine.Drow();
            rightLine.Drow();



            //HorizontalLine hLine = new HorizontalLine(5, 10, 8, '+');
            //hLine.Drow();
            //VerticalLine vLine = new VerticalLine(2, 7, 4, '+');
            //vLine.Drow();

        }

        
    }
}

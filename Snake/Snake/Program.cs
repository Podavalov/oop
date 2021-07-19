using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.SetWindowSize(90, 30);
            HorizontalLine UpLine = new HorizontalLine(0, 85, 0, '+');
            HorizontalLine DownLine = new HorizontalLine(0, 85, 25, '+');
            VerticalLine Leftline = new VerticalLine(0, 25, 0, '+');
            VerticalLine Rightline = new VerticalLine(0, 25, 85, '+');
            UpLine.Draw();
            DownLine.Draw();
            Leftline.Draw();
            Rightline.Draw();

            Point p = new Point(10, 8, '#');
            Snake snake = new Snake(p, 4, Direction.Right);
            snake.Draw();

            Console.ReadLine();
        }

       
    }
}

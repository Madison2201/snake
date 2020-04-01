using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(90, 30);
            
            HorizontalLine upline = new HorizontalLine(0,88,0,'+');
            upline.Draw();
            HorizontalLine downline = new HorizontalLine(0, 88, 29, '+');
            downline.Draw();
            VerticalLine leftLine = new VerticalLine(0, 0, 29, '+');
            leftLine.Draw();
            VerticalLine rightLine = new VerticalLine(88, 0, 29, '+');
            rightLine.Draw();

            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p,4,Direction.RIGHT);
            snake.Draw();
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();


            Console.ReadLine();
        }
    }
}

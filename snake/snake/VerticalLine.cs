using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class VerticalLine : Figure
    {
        public VerticalLine(int x, int yBeginning, int yEnd, char sym)
        {
            pList = new List<Point>();

            for (int y = yBeginning; y <= yEnd; y++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }
    }
}

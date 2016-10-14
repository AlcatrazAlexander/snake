using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VerticalLine : Figure
    {
        public VerticalLine(int yUp, int yDown, int x, char sym)
        {
            pList = new List<Point>();
            Point p;

            for (int y = yUp; y <= yDown; y++)
            {
                p = new Point(x, y, sym);
                pList.Add(p);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VertLine : Figure
    {
        public VertLine(int yTop, int yFoot, int x, char sym)
        {
            pList = new List<Point>();
            for (int y = yTop; y <= yFoot; y++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }

        }

    }
}

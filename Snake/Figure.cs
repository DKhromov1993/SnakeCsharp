using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Figure
    {
        protected List<Point> pList;

        public virtual void Draw()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }

        public virtual void Draw( ConsoleColor color )
        {
            foreach (Point p in pList)
            {
                p.Draw(color);
            }
        }

        /*public bool intersection(Figure snake, int mapWidth, int mapHeigth)
        {
            if (snake.pList.Last().x == 0 || snake.pList.Last().y == 0 || snake.pList.Last().x == mapWidth || pList.Last().y == mapHeigth)
            {
                return true;
            }
            else
                return false;
        }*/


    }
}

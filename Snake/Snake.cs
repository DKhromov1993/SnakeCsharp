using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake : Figure
    {
        Direction direction;
        public Snake(Point tail, int length, Direction _direction)
        {
            direction = _direction;
            pList = new List<Point>();
            //Snake snake = new Snake(p, 5, Direction.RIGHT);
            for (int i = 0; i < length; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                pList.Add(p);
            }
        }

        internal void Move()
        {
            Point tail = pList.First();
            pList.Remove(tail);
            Point head = getNextPoint();
            pList.Add(head);

            tail.Clear();
            head.Draw();
        }

        public Point getNextPoint()
        {
            Point head = pList.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1 , direction);
            return nextPoint;
        }

        public void iMoveTo(ConsoleKey Key)
        {
            if (Key == ConsoleKey.LeftArrow)
                direction = Direction.LEFT;
            if (Key == ConsoleKey.RightArrow)
                direction = Direction.RIGHT;
            if (Key == ConsoleKey.UpArrow)
                direction = Direction.UP;
            if (Key == ConsoleKey.DownArrow)
                direction = Direction.DOWN;
        }

        internal bool Eat(Point food)
        {
            
            Point head = pList.Last(); //getNextPoint();
            if (head.x == food.x && head.y == food.y)
            {
                food.sym = head.sym;
                pList.Add(food);
                return true;
            }
            else
                return false;
        }

        // защита от стеногрызства
        public bool crossingWall()
        {
            if (pList.Last().x == 0 || pList.Last().y == 0 || pList.Last().x == 79 || pList.Last().y == 24)
            {
                return true;
            }
            return false;
        }

        // защита от самосъедения
        public bool crossingBody()
        {
            for (int i = 0; i < pList.Count - 2; i++)
            {
                if (pList[i].x == pList.Last().x && pList[i].y == pList.Last().y)
                    return true;
            }
            return false;
        }

        public bool goodEat(Point p) // ПРоверка на совпадение еды и змейки. T - норм точка, F - точка совпадает
        {
            for (int i = 0; i < pList.Count - 1; i++)
            {
                if (p.x == pList[i].x && p.y == pList[i].y)
                    return false;
            }
            return true;
        }


        /*public override void Drow()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            //Вызов базового метода
            base.Drow();
            Console.ForegroundColor = ConsoleColor.Yellow;

        }*/

    }
}

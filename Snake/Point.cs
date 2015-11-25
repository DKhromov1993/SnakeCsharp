using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Point
    {
        public int x;
        public int y;
        public char sym;
        public String word;

        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
        }

        public void Move(int offset, Direction direction)
        {
            if (direction == Direction.RIGHT)
                x = x + offset;
            if (direction == Direction.LEFT)
                x = x - offset;
            if (direction == Direction.UP)
                y = y - offset;
            if (direction == Direction.DOWN)
                y = y + offset;

        }
        
        public Point(int x, int y, char sym)
        {
            this.x = x;
            this.y = y;
            this.sym = sym;

            //Draw();
        }
        //
        public Point(int x, int y, String word)
        {
            this.x = x;
            this.y = y;
            this.word = word;
        }
        //

        public void Clear()
        {
            sym = ' ';
            Draw();
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }

        public void Draw(ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
            Console.ResetColor();
        }
    }
}

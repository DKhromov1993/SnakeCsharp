using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Walls
    {
        List<Figure> wallList;

        public Walls(int mapWidth, int mapHeigth)
        {

            wallList = new List<Figure>();

            Console.SetWindowSize(mapWidth, mapHeigth);

            HorizontLine lineTop = new HorizontLine(0, mapWidth - 2, 0, '+');
            HorizontLine lineFoot = new HorizontLine(0, mapWidth - 2, mapHeigth -1, '+');
            VertLine leftLine = new VertLine(0, mapHeigth - 1, 0, '+');
            VertLine rightLine = new VertLine(0, mapHeigth - 1, mapWidth - 2, '+');

            wallList.Add(lineTop);
            wallList.Add(lineFoot);
            wallList.Add(leftLine);
            wallList.Add(rightLine);
        }

        public void Draw()
        {
            foreach (var wall in wallList)
            {
                wall.Draw(ConsoleColor.Red);
            }
        }
        /*
        public bool inteintersectionWall()
        {
            foreach (var wall in wallList)
            {
                if (wall.intersection(snake ,mapWidth, mapHeigth))
                    return true;
            }
            return false;
        }*/
    }
}

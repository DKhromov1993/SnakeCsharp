using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            // Рисуем границы
            Walls wall = new Walls(80, 25);
            wall.Draw();

            //рисуем змею
            Point p = new Point(4, 5, '*'); 
            Snake snake = new Snake(p, 5, Direction.RIGHT); 
            snake.Draw();
            
            //создаём еду
            FoodCreator foodCeator = new FoodCreator(78, 23, '$');
            Point food = foodCeator.CreateFood();
            food.Draw();

            while (true)
            {

                if (snake.crossingWall() || snake.crossingBody()) // проверка столкновения
                {
                    Console.Clear();
                    Console.WriteLine("Ты проиграл!");
                    Console.ReadLine();
                    break;
                }

                if (snake.Eat(food))
                {
                    food = foodCeator.CreateFood();
                    while (true)
                    {
                        if (snake.goodEat(food))
                        {
                            food.Draw();
                            break;
                        }
                        else
                            food = foodCeator.CreateFood();
                    }
                }
                else
                {
                    snake.Move();
                }

                Thread.Sleep(100);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.iMoveTo(key.Key);
                }
            }
        }
    }
}

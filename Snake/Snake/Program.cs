using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {

           

            Walls walls = new Walls(80, 20);
            walls.Draw();

            

            Point p = new Point(15, 15, '#');
            Snake snake = new Snake(p, 4, Direction.Right);
            snake.Draw();

            FoodCreator foodCreator = new FoodCreator(80, 20, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();
           

            while (true)
            {
                if (walls.IsHit(snake) || snake.IsHitTail())
                {
                    break;

                }

                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }
                Thread.Sleep(100);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandlKey(key.Key);
                }
            }
           
        }
            
    }
    
       
    }


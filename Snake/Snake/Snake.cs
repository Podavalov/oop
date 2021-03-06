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
       public Snake(Point tail, int leight, Direction _direction)
        {
            direction = _direction;
            pList = new List<Point>();
            for (int i =0; i<=leight; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                pList.Add(p);
            }
        }

        public Point GetNextPoint()
        {
            Point head = pList.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1, direction);
            return nextPoint;
        }

        internal void Move()
        {
            Point tail = pList.First();
            pList.Remove(tail);
            Point head = GetNextPoint();
              pList.Add(head);
                tail.Clear();
                head.Draw();
        }

        internal bool Eat(Point food)
        {
            Point head = pList.Last();
            if (head.IsHit(food))
            {
                food.sym = head.sym;
                pList.Add(food);
                return true;
            }
            else
            {
                return false;
            }


           
        }

        internal bool IsHitTail()
        {
            var head = pList.Last();
            for(int i=0; i< pList.Count -2; i++)
            {
                if (head.IsHit(pList[i]))
                
                    return true;
                
                
            }
            return false;
        }

        public void HandlKey(ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow)
            {
                direction = Direction.Left;
            }
            else if (key == ConsoleKey.RightArrow)
            {
                direction = Direction.Right;
            }
            else if (key == ConsoleKey.UpArrow)
            {
                direction = Direction.Up;
            }
            else if (key == ConsoleKey.DownArrow)
            {
                direction = Direction.Down;
            }
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Point p1 = new Point(1, 3, '*');
            p1.Draw();

            Point p2 = new Point(4, 5, '#');
            p2.Draw();

            */

            int x = 1;
            Funk1(x);
            Console.WriteLine("Call Funk1. x = " + x);

            x = 1;
            Funk2(x);
            Console.WriteLine("Call Funk2. x = " + x);

            x = 1;
            Funk1(x);
            Console.WriteLine("Call Funk3. x = " + x);

            Point p1 = new Point(1, 3, '*');
            Move(p1, 10, 10);
            Console.WriteLine("Call Move. p1.x = " + p1.x + ", p1.y = " + p1.y);

            Point p2 = new Point(4, 5, '#');
            p1 = p2;
            p2.x = 8;
            p2.y = 8;
            Console.WriteLine("p1 = p2. p1.x = " + p1.x + ", p1.y = " + p1.y + "; p2.x = " + p2.x + ", p2.y = " + p2.y);

            p1 = new Point(1, 3, '*');
            Update(p1);
            Console.WriteLine("Call Move. p1.x = " + p1.x + ", p1.y = " + p1.y);

            Console.ReadLine();
        }
        public static void Funk1( int value )
        {
        }
        public static void Funk2(int value)
        {
        }
        public static void Funk3(int value)
        {
        }

        public static void Move(Point p, int dx, int dy )
        {
            p.x += dx;
            p.y += dy;
        }
        public static void Update( Point p )
        {
            p = new Point();
        }
    }
}

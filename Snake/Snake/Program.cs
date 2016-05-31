using System;
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
            Point p1 = new Point(1, 3, '*');
            p1.Draw();

            Point p2 = new Point(4, 5, '#');
            p2.Draw();

            Point p3 = new Point(8, 8, '$');
            p3.Draw();

            Point p4 = new Point(8, 15, '$');
            p4.Draw();

            Point p5 = new Point(20, 15, '$');
            p5.Draw();

            Point p6 = new Point(20, 8, '$');
            p6.Draw();

            List < int > numList = new List<int>();
            numList.Add(0);
            numList.Add(1);
            numList.Add(2);

            int x = numList[ 0 ];
            int y = numList[ 1 ];
            int z = numList[ 2 ];

            foreach( int i in numList )
            {
                Console.WriteLine(i);
            }

            numList.RemoveAt(0);

            List<Point> plist = new List<Point>();
            plist.Add(p1);
            plist.Add(p2);

            List<char> symb = new List<char>();
            symb.Add('!');
            symb.Add('@');
            symb.Add('#');
            symb.Add('$');
            symb.Add('*');

            foreach(char i in symb)
            {
                Console.WriteLine(i);
            }

            List<Point> rec = new List<Point>();
            rec.Add(p3);
            rec.Add(p4);
            rec.Add(p5);
            rec.Add(p6);


            for ( int i = 0; i < 4; i++ )
            {
                Console.WriteLine(rec[ i ]);
            }


            Console.ReadLine();
        }
    }
}

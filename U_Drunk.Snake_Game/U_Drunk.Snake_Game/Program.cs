using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U_Drunk.Snake_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 3,'*');
       

            //p1.Draw();

            Point p2 = new Point(4, 5, '#');

            //p2.Draw();

            Point p3 = new Point(6, 7, '%');
            Point p4 = new Point(5, 12, '$');

            List<int> numList = new List<int>();

            numList.Add(0);
            numList.Add(1);
            numList.Add(2);

            int x = numList[0];
            int y = numList[1];
            int z = numList[2];

            //foreach (int i in numList)
            //{
            //    Console.WriteLine(i);
            //}

            numList.RemoveAt(0);

            List<Point> pList = new List<Point>();
            pList.Add(p1);
            pList.Add(p2);
            pList.Add(p3);
            pList.Add(p4);


            char sym1 = '*';
            char sym2 = '#';
            char sym3 = '&';
            char sym4 = '%';

            List<char> cList = new List<char>();

            cList.Add(sym1);
            cList.Add(sym2);
            cList.Add(sym3);
            cList.Add(sym4);

            //foreach(char c in cList)
            //{
            //    Console.WriteLine(c);
            //}

            foreach(Point p in pList)
            {
                p.Draw();
            }


            Console.ReadLine();







        }


    }
}

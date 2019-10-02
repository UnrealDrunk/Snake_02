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
       

            p1.Draw();

            Point p2 = new Point(4, 5, '#');

            p2.Draw();

            List<int> numList = new List<int>();

            HorizontalLine line = new HorizontalLine(5,10,8,'+');
            line.Drow();




        }


    }
}

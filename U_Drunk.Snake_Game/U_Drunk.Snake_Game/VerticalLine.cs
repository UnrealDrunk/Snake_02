using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U_Drunk.Snake_Game
{
    class VerticalLine
    {
        List<Point> pList;

        public VerticalLine(int x, int yUpper, int yLower, char sym)
        {
            pList = new List<Point>();
            for(int i = yUpper; i <= yLower; i++)
            {
                Point p = new Point(x, i, sym);
                pList.Add(p);
            }
        }

        public void Drow()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }
    }
}

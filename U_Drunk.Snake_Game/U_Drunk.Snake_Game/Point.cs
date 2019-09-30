using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U_Drunk.Snake_Game
{
    class Point
    {
        public int x, y;
        public char sym;

        public Point()
        {
            
        }
        /// <summary>
        /// Конструктор по двум точкам с обозначением символа точки
        /// </summary>
        /// <param name="_x">координата по оси х</param>
        /// <param name="_y">координата по оси у</param>
        /// <param name="_sym">внешний вид символа</param>
        public Point(int _x, int _y, char _sym)
        {
            x = _x;
            y = _y;
            sym = _sym;
        }


        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(sym);
        }

    }
}

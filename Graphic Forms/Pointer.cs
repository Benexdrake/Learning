using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphic_Forms
{
    internal class Pointer
    {
        private int x1;
        private int x2;
        private int y1;
        private int y2;

        public int X1 { get => x1; set => x1 = value; }
        public int X2 { get => x2; set => x2 = value; }
        public int Y1 { get => y1; set => y1 = value; }
        public int Y2 { get => y2; set => y2 = value; }

        public Pointer(int _x1, int _y1, int _x2, int _y2)
        {
            x1 = _x1;
            y1 = _y1;
            x2 = _x2;
            y2 = _y2;
        }
    }
}

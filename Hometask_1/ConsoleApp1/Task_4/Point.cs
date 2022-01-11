using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Point
    {
        string name; public string Name { get; }
        int x; //public int X { get; }
        public int X
        {
            get { return x; }
        }
        int y; //public int Y { get; }
        public int Y
        {
            get { return y; }
        }

        public Point(string name, int x, int y)
            {
            this.name = name;
            this.x = x;
            this.y =y;
            }
    }
}

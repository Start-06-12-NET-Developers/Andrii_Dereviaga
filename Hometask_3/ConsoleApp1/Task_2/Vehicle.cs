using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Vehicle
    {
        public double price;
        public int speed;
        public int date;

        internal Vehicle(double price, int speed, int date)
        { 
        
            this.price = price;
            this.speed = speed;
            this.date = date;   
        
        }

        public virtual void PrintInfo()
        { }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class TXTHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("TXT Opened");
        }
        public override void Create()
        {
            Console.WriteLine("TXT Created");
        }
        public override void Change()
        {
            Console.WriteLine("TXT Changed");
        }
        public override void Save()
        {
            Console.WriteLine("TXT Saved");
        }
    }
}

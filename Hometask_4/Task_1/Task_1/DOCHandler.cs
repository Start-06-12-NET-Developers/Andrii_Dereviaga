using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class DOCHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("DOC Opened");
        }
        public override void Create()
        {
            Console.WriteLine("DOC Created");
        }
        public override void Change()
        {
            Console.WriteLine("DOC Changed");
        }
        public override void Save()
        {
            Console.WriteLine("DOC Saved");
        }
    }
}

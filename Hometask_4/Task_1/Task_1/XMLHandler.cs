using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class XMLHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("XML Opened");
        }
        public override void Create()
        {
            Console.WriteLine("XML Created");
        }
        public override void Change()
        {
            Console.WriteLine("XML Changed");
        }
        public override void Save()
        {
            Console.WriteLine("XML Saved");
        }
    }
}

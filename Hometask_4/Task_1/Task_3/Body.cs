using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Body : OverallVirtualDocument
    {

        string bodyInfo;
        public string BodyInfo
        {
            internal get
            {
                if (bodyInfo != null)
                    return bodyInfo;
                else
                    return "Document has no body";
            }
            set
            {
                bodyInfo = value;
            }
        }
        public override void Create()
        {
            Console.WriteLine($"Created Body is {bodyInfo}");
        }

        public override void Edit(string newBody)
        {
            this.bodyInfo = newBody;
            Console.WriteLine($"Edited Body is {bodyInfo}");
        }

        public override void Write()
        {
            Console.WriteLine($"Body is {bodyInfo}");
        }

    }
}

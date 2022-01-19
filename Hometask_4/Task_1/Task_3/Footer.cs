using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Footer : OverallVirtualDocument
    {
        string footerInfo;
        public string FooterInfo
        {
            internal get
            {
                if (footerInfo != null)
                    return footerInfo;
                else
                    return "Document has no footer";
            }
            set
            {
                footerInfo = value;
            }
        }
        public override void Create()
        {
            Console.WriteLine($"Created Footer is {footerInfo}");
        }

        public override void Edit(string newFooter)
        {
            this.footerInfo = newFooter;
            Console.WriteLine($"Modified Footer is {footerInfo}");
        }

        public override void Write()
        {
            Console.WriteLine($"Footer is {footerInfo}");
        }
    }
}

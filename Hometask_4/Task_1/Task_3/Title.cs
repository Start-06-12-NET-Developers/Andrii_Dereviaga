using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Title : OverallVirtualDocument
    {
        string titleInfo;
        public string TitleInfo
        {
            internal get
            {
                if (titleInfo != null)
                    return titleInfo;
                else
                    return "Title has no body";
            }
            set
            {
                titleInfo = value;
            }
        }
        public override void Create()
        {
            Console.WriteLine($"Created Title is {titleInfo}");
        }

        public override void Edit(string newTitle)
        {
            this.titleInfo = newTitle;
            Console.WriteLine($"Edited Title is {titleInfo}");
        }

        public override void Write()
        {
            Console.WriteLine($"Title is {titleInfo}");
        }
    }
}

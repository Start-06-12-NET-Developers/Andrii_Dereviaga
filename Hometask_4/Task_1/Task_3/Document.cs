using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Document
    {
        Title title;
        Body body;
        Footer footer;



        public Document (Title title, Body body, Footer footer)
        { 
            this.title = title;
            this.body = body;   
            this.footer = footer;
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Title - {title.TitleInfo}\nFooter - {footer.FooterInfo}\nBody - {body.BodyInfo}");
            Console.WriteLine(new string('-', 200));
            Console.ResetColor();
        }
    }
}

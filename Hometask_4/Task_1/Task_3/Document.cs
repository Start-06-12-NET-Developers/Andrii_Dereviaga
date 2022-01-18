using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Document
    {
        string title;
        string body;
        string footer;

        public string Title
        {
            private get
            {
                if (title != null)
                    return title;
                else
                    return "Тело документа отсутствует.";
            }
            set
            {
                title = value;
            }
        }

            public string Body
        {
            private get
            {
                if (body != null)
                    return body;
                else
                    return "Тело документа отсутствует.";
            }
            set
            {
                body = value;
            }
        }

        public string Footer
        {
            private get
            {
                if (footer != null)
                    return footer;
                else
                    return "Тело документа отсутствует.";
            }
            set
            {
                footer = value;
            }
        }

        public Document(string title, string body, string footer)
        { 
            this.title = title;
            this.body = body;   
            this.footer = footer;
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Title - {title}\nFooter - {footer}\nBody - {body}");
            Console.ResetColor();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Title title1 = new Title();
            title1.TitleInfo = "War and Pease";

            Body body1 = new Body();
            body1.BodyInfo = "It was in July, 1805, and the speaker was the well-known" +
                " Anna Pavlovna Scherer, maid of honor and favorite of the Empress Marya Fedorovna.";
            
            Footer footer1 = new Footer();
            footer1.FooterInfo = "This edition has some notes at the end, but no endnotes or footnotes," +
                " or any of the other notes that are supposedly in the Pevear translation.";
            
            Document document = new Document(title1, body1, footer1);
            document.Show();

            Console.ReadKey();
        }
    }
}

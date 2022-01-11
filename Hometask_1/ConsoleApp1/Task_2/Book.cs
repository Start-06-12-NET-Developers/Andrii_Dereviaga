using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Book
    {
        Author author;
        Contents contents;
        Title title;

        public Book(Author author, Contents contents, Title title)
        {
            this.author = author;
            this.contents = contents;   
            this.title = title;        
        }

        public void Show()
        {
            this.title.Show();
            this.author.Show();
            this.contents.Show();
              
        }



    }
}

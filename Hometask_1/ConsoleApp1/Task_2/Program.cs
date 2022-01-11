using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter author");
            Author author = new Author();
            author.Content = Console.ReadLine();

            Console.WriteLine("Enter title");
            Title title = new Title();
            title.Content = Console.ReadLine();

            Console.WriteLine("Enter Contents");
            Contents contents = new Contents();
            contents.Content = Console.ReadLine();

            Book book = new Book(author,contents,title);
            book.Show();

            Console.ReadKey();

        }
    }
}

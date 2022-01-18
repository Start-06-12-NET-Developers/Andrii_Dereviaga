using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class User
    {
        static public readonly DateTime date = DateTime.Now;
        public DateTime Date
        {
            get { return date; }
        }
        string login;
        
        string name;
        public string Name
        {
            get { return name; }
        }

        string surname;
        public string Surname
        {
            get { return surname; }
        }
        int age;
        public int Age
        {
            get { return age; }
        }

        public User(string login, string name, string surname, int age)
        {

            if (login != "Correct") { Console.WriteLine("Incorrect login"); Console.ReadKey(); Environment.Exit(0); }

            this.login = login;
            this.name = name; 
            this.surname = surname;
            this.age = age;
        
        }
    }
}

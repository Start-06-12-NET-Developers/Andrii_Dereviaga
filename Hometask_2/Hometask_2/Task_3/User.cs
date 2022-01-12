using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class User
    {
        public readonly DateTime date = DateTime;
        public DateTime Date
        {
            get { return date; }
        }
        string login;
        public string Login
        {
            get { return name; }
        }
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

        public User(string name, string surname, int age)
        { 
        
            //this.date = DateTime.Now;
            this.name = name; 
            this.surname = surname;
            this.age = age;
        
        }
    }
}

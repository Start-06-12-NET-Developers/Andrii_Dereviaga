using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Employee
    {
        string surname;
        string name;

        public string Surname
        {
            get { return surname; }
        }
        public string Name
        {
            get { return name; }
        }

        public Employee(string surname, string name)
            {
            this.surname = surname;
            this.name = name;
            }

        public double SalaryCalculator(int experience, string position)
        {
            double monthAveragePayment = 1000;
            double salary = 0;
            double coefficient = 0;
            
            switch (experience)
            {
                case int k when (k < 3): { coefficient = 1; break; } 
                case int k when ( k >= 3 && k < 10): { coefficient = 1.5; break; }
                case int k when (k >= 10): { coefficient = 2; break; }
            }

            if (position == "director") coefficient += 3;
            else if (position == "engineer") coefficient += 2;
            else coefficient += 1;

            salary = monthAveragePayment * coefficient;

            return salary;
        }

        
    }
}

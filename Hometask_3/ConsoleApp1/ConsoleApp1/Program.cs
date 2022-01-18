using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pupil pupil1 = new Pupil();
            Pupil pupil2 = new Pupil();
            Pupil pupil3 = new Pupil();
            Pupil pupil4 = new Pupil();

            Classroom class1 = new Classroom(pupil1, pupil2, pupil3, pupil4);
            class1.PupilsActions();

            

        }
    }
}

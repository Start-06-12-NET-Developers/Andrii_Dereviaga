using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ExcellentPupil : Pupil
    {
        public override void Study()
        { Console.WriteLine("Study excellent"); }

        public override void Read()
        { Console.WriteLine("Read excellent"); }

        public override void Write()
        { Console.WriteLine("Write excellent"); }

        public override void Relax()
        { Console.WriteLine("Relax little bit"); }

    }

    internal class GoodPupil : Pupil
    {
        public override void Study()
        { Console.WriteLine("Study good"); }

        public override void Read()
        { Console.WriteLine("Read good"); }

        public override void Write()
        { Console.WriteLine("Write good"); }

        public override void Relax()
        { Console.WriteLine("Relax normal"); }
    }

    internal class BadPupil : Pupil
    {
        public override void Study()
        { Console.WriteLine("Study bad"); }

        public override void Read()
        { Console.WriteLine("Read bad"); }

        public override void Write()
        { Console.WriteLine("Write bad"); }

        public override void Relax()
        { Console.WriteLine("Relax a lot"); }
    }

    
}

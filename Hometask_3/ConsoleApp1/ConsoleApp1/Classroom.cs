using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Classroom
    {
        Pupil[] pupilsArray = new Pupil[4];
 
        public Classroom(Pupil pupil1 = null, Pupil pupil2 = null, Pupil pupil3 = null, Pupil pupil4 = null )
        {
            this.pupilsArray[0] = new GoodPupil();
            this.pupilsArray[1] = new BadPupil();
            this.pupilsArray[2] = new ExcellentPupil();
            this.pupilsArray[3] = new BadPupil();

        }

        public Classroom(Pupil pupil1 = null, Pupil pupil2 = null, Pupil pupil3 = null)
        {
            this.pupilsArray[0] = new GoodPupil();
            this.pupilsArray[1] = new BadPupil();
            this.pupilsArray[2] = new ExcellentPupil();
        
        }

        public Classroom(Pupil pupil1 = null, Pupil pupil2 = null)
        {
            this.pupilsArray[0] = new GoodPupil();
            this.pupilsArray[1] = new BadPupil();
            
        }

        public void PupilsActions()
        {
            
                for (int i = 0; i < 4; i++)
                {
                    if (pupilsArray[i] != null)
                    {
                    pupilsArray[i].Study();
                    pupilsArray[i].Read();
                    pupilsArray[i].Write();
                    pupilsArray[i].Relax();
                     
                
                    }
                Console.WriteLine();


                }
            Console.ReadKey();
            
            
        
        
        }

    }
}

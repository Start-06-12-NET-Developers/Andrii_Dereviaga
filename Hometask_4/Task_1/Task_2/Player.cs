using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Player : IPlayable, IRecordable
    {
        public void Play()
        {
            Console.WriteLine("Play"); 
        }

        public void Pause()
        {
            Console.WriteLine("Pause");
        }

        public void Stop()
        {
            Console.WriteLine("Stop");
        }

        public void Record()
        {
            Console.WriteLine("Record");
           
        }
       
    }

}

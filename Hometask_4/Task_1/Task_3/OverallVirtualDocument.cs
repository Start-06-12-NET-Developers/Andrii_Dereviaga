using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    abstract class OverallVirtualDocument
    {
        public abstract void Create();
        public abstract void Edit(string variable);
        public abstract void Write();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_interfejsy.classes
{
    internal abstract class Media
    {
        public virtual void Stop()
        {
            Console.WriteLine("Klasa MEDIA - metoda STOP");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_interfejsy.classes
{
    internal class Comedy : Film
    {
        public void Stop()
        {
            Console.WriteLine("Klasa Comedy - metoda STOP");
        }
        public void Play()
        {
            Console.WriteLine("Klasa Comedy - metoda PLAY");
        }
    }
}

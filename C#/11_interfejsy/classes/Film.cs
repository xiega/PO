using _11_interfejsy.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_interfejsy.classes
{
    internal class Film : IPlayable
    {
        public void Stop()
        {
            Console.WriteLine("Klasa FILM - metoda STOP");
        } 
        public void Play()
        {
            Console.WriteLine("Klasa FILM - metoda PLAY");
        }
    }
}

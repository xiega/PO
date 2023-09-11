using _11_interfejsy.classes;
using _11_interfejsy.interfaces;

namespace _11_interfejsy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPlayable[] tabMedia = new IPlayable[3];
            //tabMedia[0] = new Media();    nie można, bo jest to klasa abstrakcyjna
            tabMedia[0] = new Film();
            tabMedia[1] = new Comedy();
            tabMedia[2] = new Comedy();

            foreach(IPlayable media in tabMedia)
            {
                media.Stop();
            }
        }
    }
}
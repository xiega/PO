using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Person
    {
        public string firstName = "";
        public string lastName = "";
        byte age = 0;

        static int Number = 0;

        public Person()
        {
            Number++;
        }

        public Person(string name, string surname, byte a)
        {
            firstName = name;
            lastName = surname;
            age = a;
        }

        ~Person()
        {
            Number--;
        }

        public void showData()
        {
            Console.WriteLine("Imię i nazwisko: " + firstName + " " + lastName + ", wiek: " + age);
        }

        public int getNumber()
        {
            return Number;
        }
    }
}

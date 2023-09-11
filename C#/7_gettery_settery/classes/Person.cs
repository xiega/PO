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
        float height;
        float weight;

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

        public void setAge(byte age)
        {
            this.age = age;
        }

        public byte getAge()
        {
            return age;
        }

        public float Height
        {
            set { height = value; }
            get { return height; }
        }

        public float Weight
        {
            set { if(value>0 && value<700) weight = value; }
            get { return weight; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Student : Person
    {
        public enum classesAtSchool
        {
            _1a,
            _2a, _2b, _2c,
            _3a
        }

        public classesAtSchool studentClass = classesAtSchool._1a;

        public Student() { }

        public Student(string firstName, string lastName, classesAtSchool studentClass) : base(firstName, lastName)
        {
            this.studentClass = studentClass;
        }

        public new string Info()
        {
            return base.Info() + ", klasa: " + studentClass.ToString().Substring(1);
        }
    }
}

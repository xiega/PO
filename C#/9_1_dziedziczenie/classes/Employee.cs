using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Employee : Person
    {
        private float ratePerHour = 0;
        private ushort numberOfWorkHours = 0;

        public Employee() { }

        public Employee(string _firstName, string _lastName, float _ratePerHour, ushort _numberOfWorkHours) : base(_firstName, _lastName)
        {
            this.ratePerHour= _ratePerHour;
            this.numberOfWorkHours= _numberOfWorkHours;
        }

        private float Salary()
        {
            return ratePerHour * numberOfWorkHours;
        }

        public new string Info()
        {
            return base.Info() + ",pensja: " + Salary().ToString("C4");
        }
    }
}

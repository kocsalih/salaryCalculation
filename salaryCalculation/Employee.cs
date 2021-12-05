using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salaryCalculation
{
    public abstract class Employee
    {

        private string firstName;

        public string _firstName
        {
            get { return firstName; }
            set { firstName = value; }
        }


        private string lastName;

        public string _lastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        private string ssn;

        public string _ssn
        {
            get { return ssn; }
            set { ssn = value; }
        }


        public abstract double earnings();


        public  override string ToString()
        {
            return string.Format(_firstName + " " + _lastName + "ssn:  "+_ssn);
        }


    }
}

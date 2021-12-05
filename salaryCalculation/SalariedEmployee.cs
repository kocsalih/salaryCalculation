using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salaryCalculation
{
    public class SalariedEmployee : Employee
    {

        private double weaklySalary;

        public double _weaklySalary
        {
            get { return weaklySalary; }
            set { weaklySalary = value; }
        }

        public SalariedEmployee(double WeaklySalary)
        {
            _weaklySalary = weaklySalary;

        }

        public override double earnings()
        {
            return _weaklySalary;
        }


        public override string ToString()
        {
            return string.Format("Salaried employee\n" + _firstName + " " + _lastName + " Social Security Number: " + _ssn + " Weakly salary: " +_weaklySalary + " Total Earning: " + earnings());
        }

    }
}

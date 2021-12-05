using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salaryCalculation
{
    public class HourlyEmployee : Employee
    {

        private double hours;

        public double _hours
        {
            get { return hours; }
            set { hours = value; }
        }


        private double wage;

        public double _wage
        {
            get { return wage; }
            set { wage = value; }
        }


        public HourlyEmployee(double hours,double wage)
        {
            _hours = hours;
            _wage = wage;
        }




        public override double earnings()
        {
            if (_hours <= 40)
            {
                return _hours * _wage;
            }
            else
            {
                return (40 * _wage) + (_hours - 40) * 1.5 * _wage;
            }
        }


        public override string ToString()
        {
            return string.Format("Hourly employe\n"+_firstName + " " + _lastName + " Social Security Number: " + _ssn+" Hourly wage: "+wage+" Hours Worked: "+_hours+" Total Earning: "+earnings());
        }
    }
}

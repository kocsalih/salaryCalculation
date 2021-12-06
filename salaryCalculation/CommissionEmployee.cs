using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salaryCalculation
{
    public class CommissionEmployee : Employee
    {

        private double grossSales;

        public double _grossSales
        {
            get { return grossSales; }
            set { grossSales = value; }
        }


        private double commissionRate;

        public double _commissionRate
        {
            get { return commissionRate; }
            set { commissionRate = value; }
        }

        public CommissionEmployee(double GrossSale,double Commission )
        {
            _grossSales = GrossSale;
            _commissionRate = Commission;
        }
        public CommissionEmployee()
        {

        }

        public override double earnings()
        {
            return _commissionRate * _grossSales;
        }

        public override string ToString()
        {
            return string.Format("Commission employee\n" + _firstName + " " + _lastName + " Social Security Number: " + _ssn + " Gross sale: " + _grossSales + " Commission rate: " + _commissionRate + " Total Earning: " + earnings());
        }
    }
}

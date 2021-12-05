using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salaryCalculation
{
    public class BasePlusCommissionEmployee : Employee
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


        private double baseSalary;

        public double _baseSalary
        {
            get { return baseSalary; }
            set { baseSalary = value; }
        }
        public BasePlusCommissionEmployee(double commission,double grossSale,double baseSale)
        {
            _commissionRate = commission;
            _grossSales = grossSale;
            _baseSalary = baseSale;
        }


        public override double earnings()
        {
            return (_commissionRate * _grossSales) + _baseSalary;
        }


        public override string ToString()
        {
            return string.Format("BasePlus commission employee\n" + _firstName + " " + _lastName + " Social Security Number: " + _ssn + " Gross sale: " + _grossSales + " Commission rate: " + _commissionRate + " Base salary: " + _baseSalary + " Total Earning: " + earnings());
        }

    }
}

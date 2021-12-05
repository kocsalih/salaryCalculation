using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salaryCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            SalariedEmployee s1 = new SalariedEmployee(20);
            s1._firstName = "salih";
            s1._lastName = "Koç";
            s1._ssn = "14528597";
            s1._weaklySalary = 10;
            Console.WriteLine(s1.ToString());


            HourlyEmployee h1 = new HourlyEmployee(15, 30);
            h1._firstName = "Abdullah";
            h1._lastName = "koç";
            h1._ssn = "4455555888";
            Console.WriteLine(h1.ToString());


            CommissionEmployee c1 = new CommissionEmployee(15, 10);
            c1._firstName = "Bünyamin";
            c1._lastName = "Koç";
            c1._ssn = "156488888888";
            Console.WriteLine(c1.ToString());


            BasePlusCommissionEmployee b1 = new BasePlusCommissionEmployee(0.1, 10, 15);
            b1._firstName = "Mehmet";
            b1._lastName = "cenk";
            b1._ssn = "5558888222";
            Console.WriteLine(b1.ToString());




            Console.ReadLine();
        }
    }
}

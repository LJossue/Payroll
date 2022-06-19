using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Payroll
{
    internal class Employee
    {
        private int Document;
        private string Name;
        private string LastName;
        private double Salary;
        private double WorkedDays;
        private double SalaryEarned;
        private double Health;
        private double Pension;
        private double SubsidyTransport;

        public Employee()
        {


        }
        public int Document1 { get => Document; set => Document = value; }
        public string Name1 { get => Name; set => Name = value; }
        public string LastName1 { get => LastName; set => LastName = value; }
        public double Salary1 { get => Salary; set => Salary = value; }
        public double WorkedDays1 { get => WorkedDays; set => WorkedDays = value; }
        public double SalaryEarned1 { get => SalaryEarned; set => SalaryEarned = value; }
        public double Health1 { get => Health; set => Health = value; }
        public double Pension1 { get => Pension; set => Pension = value; }
        public double SubsidyTransport1 { get => SubsidyTransport; set => SubsidyTransport = value; }
    }
}

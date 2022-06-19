using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Payroll
{
    internal class Pays
    {
        Employee myEmployee = new Employee();
        public void PayData()
        {
            
            Console.WriteLine("Insert the Document: ");
            myEmployee.Document1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insert the Name: ");
            myEmployee.Name1 = Console.ReadLine();
            Console.WriteLine("Insert the Last Name: ");
            myEmployee.LastName1 = Console.ReadLine();
            Console.WriteLine("Insert the Salary: ");
            myEmployee.Salary1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Insert the Worked Days: ");
            myEmployee.WorkedDays1 = double.Parse(Console.ReadLine());


            myEmployee.SalaryEarned1 = myEmployee.Salary1 / 30;
            myEmployee.SalaryEarned1 = myEmployee.SalaryEarned1 * myEmployee.WorkedDays1;

            myEmployee.Health1 = myEmployee.SalaryEarned1 * 0.04;
            myEmployee.Pension1 = myEmployee.SalaryEarned1 * 0.04;

            myEmployee.SubsidyTransport1 = (117172 / 30) * myEmployee.WorkedDays1;

            if (myEmployee.Salary1 <= 2000000)
            {

                myEmployee.SalaryEarned1 = myEmployee.SalaryEarned1 + myEmployee.SubsidyTransport1;
            }
            else
            {
                myEmployee.SalaryEarned1 = myEmployee.SalaryEarned1;
            }
        }
        public void Impression()
        {
            Console.WriteLine("\n-------------------------------------\n");
            Console.WriteLine($"Document: {myEmployee.Document1}");
            Console.WriteLine($"Name: {myEmployee.Name1}");
            Console.WriteLine($"Last Name: {myEmployee.LastName1}");
            Console.WriteLine("The salary is: " + myEmployee.Salary1);
            Console.WriteLine($"Worked days: {myEmployee.WorkedDays1}");
            if (myEmployee.Salary1 <= 2000000)
            {
                Console.WriteLine($"The Transport subsidy is : {myEmployee.SubsidyTransport1}");
            }
            Console.WriteLine("The Total Accrued is:  " + myEmployee.SalaryEarned1);
            Console.WriteLine("The Health discount is: " + myEmployee.Health1);
            Console.WriteLine("The Pension discount is: " + myEmployee.Pension1);

        }

        public void FileData()

        {
            
            

            TextWriter File = new StreamWriter("C:\\Payroll.txt", true);
            
                File.WriteLine($"\n----------New Employee----------");
                File.WriteLine($"Document: {myEmployee.Document1}");
                File.WriteLine($"Name: {myEmployee.Name1}");
                File.WriteLine($"Last Name: {myEmployee.LastName1}");
                File.WriteLine("The salary is: " + myEmployee.Salary1);
                File.WriteLine($"Worked days: {myEmployee.WorkedDays1}");
                if (myEmployee.Salary1 <= 2000000)
                {
                    File.WriteLine($"The Transport subsidy is : {myEmployee.SubsidyTransport1}");
                }
                File.WriteLine("The Total Accrued is:  " + myEmployee.SalaryEarned1);
                File.WriteLine("The Health discount is: " + myEmployee.Health1);
                File.WriteLine("The Pension discount is: " + myEmployee.Pension1);
         

            File.Close();

        }
    }
}

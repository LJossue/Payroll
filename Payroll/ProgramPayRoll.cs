using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Payroll
{
    internal class ProgramPayRoll
    {
        public int NumberEmployee = 1;


        public static void Main(string[] args)
        {
            ProgramPayRoll programPayroll = new ProgramPayRoll();
            Console.WriteLine("Welcome to the payroll program.");
            Pays myPays = new Pays();
            
            
            int menu = 1;

            do
            {
                Console.WriteLine("\n-----------------------------------------\n" +
                    "\nSelect an option:\n1) To add a employee. \n2) Exit the program.\n");
                menu = int.Parse(Console.ReadLine());

                switch (menu)
                {
                    case 1:
                        {
                            Console.WriteLine($"----------Employee Number {programPayroll.NumberEmployee}----------");
                            myPays.PayData();
                            myPays.Impression();
                            myPays.FileData();


                            break;
                        }
                    case 2:
                        {
                            Console.Clear();
                            Console.WriteLine("End of the program");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Please insert a correct number.");
                            break;
                        }
                        Console.WriteLine("---------------------------------------------------------\n\n");
                        Console.Clear();
                }
                programPayroll.NumberEmployee++;
            } while (menu != 2);


        }

      

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeWage
{
    public class EmpWage
    {
        public int empHrs;
        public int empTotalWage;

        public void Employe()
        {
            const int Full_Time = 1;
            const int Part_Time = 2;
            int empHrs = 0;
            int empWagePrHr = 20;
            int total_Wage = 0;
            Random random = new Random();
            int RandomNumber = random.Next(0, 3);
            switch (RandomNumber)
            {
                case Full_Time:
                    empHrs = 8;
                    Console.WriteLine(" Employee is worked for full time");
                    break;

                case Part_Time:
                    empHrs = 4;
                    Console.WriteLine("Employee is worked for part time");
                    break;

                default:
                    Console.WriteLine("Employee is absent");
                    break;
            }

            total_Wage = empHrs * empWagePrHr;
            Console.WriteLine("Employee wage is" + total_Wage);
        }
    }
}

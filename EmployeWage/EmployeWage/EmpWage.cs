using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeWage
{
    public class EmpWage
    {
        public static void Employee()
        {
            const int Full_Time = 1;
            const int Part_Time = 2;
            int empHrs = 0;
            int totalHrs = 0;
            int empWagePrHr = 20;
            int total_Wage = 0;
            int Max_Working_Days = 20;
            int days = 1;
            Random random = new Random();


            //Writting for loop to repeate the loop untill its condition get false 
            for (days = 1; days < Max_Working_Days; days++)
            {
                //generating random numbers to check emp present or not
                int RandomNumber = random.Next(0, 3);
                if (RandomNumber == Full_Time)
                {
                    Console.WriteLine("Emplyee worked for full time");
                    empHrs = 8;
                }
                else if (RandomNumber == Part_Time)
                {
                    Console.WriteLine("Emplyee worked for part time");
                    empHrs = 4;
                }
                else
                {
                    Console.WriteLine("Emplyee is absent");
                    empHrs = 0;
                }
                //adding emp total hours 
                totalHrs += empHrs;
                //calculating total wage
                total_Wage = totalHrs * empWagePrHr;
                //printing total wage
                Console.WriteLine("Employee wage is" + total_Wage);
            }

        }
    }
}

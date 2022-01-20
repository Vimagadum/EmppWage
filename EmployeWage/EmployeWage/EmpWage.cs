using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeWage
{
    public class EmpWage
    {
        public const int FULL_TIME = 1;
        public const int PART_TIME = 2;
        public static int empHrs = 0;

        //method to calculate wage for multiple companies
        public void Employee(string company, int EmpRatePerHr, int MaxWorkingDays, int MaxWorkingHrs)
        {

            int totalWage = 0;
            int empWage;            
            int days = 1;
            int empWorkingHrs = 0;

            //generating random number
            Random random = new Random();
            //iterating emp hours out of max hours and days out of max working days 
            while (empWorkingHrs < MaxWorkingHrs && days <= MaxWorkingDays)
            {
               int randomInput = random.Next(0, 3);
                //calling method to get working hours of employee
                GetWorkingHrs(randomInput);
                empWage = EmpRatePerHr * empHrs;
                //Console.WriteLine("EMployee wage for DAy {0} is {1}", days, empWage);
                totalWage += empWage;
                empWorkingHrs += empHrs;
                
                if (empWorkingHrs > MaxWorkingHrs)
                {

                    empWorkingHrs = MaxWorkingHrs;
                    break;
                }
                days++;

            }
            Console.WriteLine(" In {0} company Employee worked for {1}days out of {2}days and {3}hours out of {4}hours so Employe wage is:{5} ", company, days - 1, MaxWorkingDays, empWorkingHrs, MaxWorkingHrs, totalWage);
        }

        //method to get working hours of employee
        public static void GetWorkingHrs(int randomInput)
        {

            switch (randomInput)
            {
                case FULL_TIME:
                    empHrs = 8;
                    //Console.WriteLine("Employee is present fulltime "+empHrs);
                    break;
                case PART_TIME:
                    empHrs = 4;
                    //Console.WriteLine("Employee is present parttime " +empHrs);
                    break;
                default:
                    empHrs = 0;
                    //Console.WriteLine("Employee is absent " +empHrs);
                    break;
            }
        }
    }
}


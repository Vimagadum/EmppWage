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
        public static void Employee()
        {

            int totalWage = 0;

            int empWage;
            const int EMP_RATE_PER_HR = 20;
            const int MAX_WORKING_DAYS = 20;
            const int MAX_WORKING_HRS = 100;
            int days = 1;
            int empWorkingHrs = 0;


            //generating random number
            Random random = new Random();
            //iterating days out of max working days and hours 
            while (days <= MAX_WORKING_DAYS && empWorkingHrs <= MAX_WORKING_HRS)
            {


                int randomInput = random.Next(0, 3);

                //calling method to get working hours
                GetWorkingHrs(randomInput);
                empWage = EMP_RATE_PER_HR * empHrs;
                Console.WriteLine("EMployee wage for DAy {0} is {1}", days, empWage);
                totalWage += empWage;
                empWorkingHrs += empHrs;
                days++;

            }
            Console.WriteLine("total wage for {0}Days and hrs:{1} is:{2} ", MAX_WORKING_DAYS, empWorkingHrs, totalWage);
        }


        //method to calculate emp hours
        public static void GetWorkingHrs(int randomInput)
        {
            //switc case to check emp present or not
            switch (randomInput)
            {
                case FULL_TIME:
                    empHrs = 8;
                    Console.WriteLine("Employee is present fulltime");
                    break;
                case PART_TIME:
                    empHrs = 4;
                    Console.WriteLine("Employee is present parttime");
                    break;
                default:
                    empHrs = 0;
                    Console.WriteLine("Employee is absent");
                    break;
            }
        }


    }
}


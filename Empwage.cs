using System;
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> e269f828627cecf9b9cdf2ea58e6066b8ed5baac
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageCompute058
{
<<<<<<< HEAD
    public class UC2_EmpWage
    {
        public static void EmpWage()
        {
            //Constants
            int IS_FULL_TIME = 1;
=======
=======
using System.Collections.Generic;
using System.Text;
>>>>>>> UC-4Switchcasestatement

namespace HelloWorld
{
    public class UC6_WageTillNumOfWorkingDays
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int NUM_OF_WORKING_DAYS = 20;
        public const int MAX_HRS_IN_MONTH = 100;
        public static void Main(string[] args)
        {
<<<<<<< HEAD
            //UC3 wage
            //Constants
            int IS_PART_TIME = 1;
            int IS_FULL_TIME = 2;
>>>>>>> UC-3AddParttimeempwage
            int EMP_RATE_PER_HOUR = 20;
=======
>>>>>>> UC-4Switchcasestatement
            //Variables
            int empHrs = 0;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;
            Random random = new Random();
            //Computation
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
            int empCheck = random.Next(0, 2);
            if (empCheck == IS_FULL_TIME)
=======
            int empCheck = random.Next(0, 3);
            switch (empCheck)
            {
<<<<<<< HEAD
                empHrs = 4;
            }
            else if (empCheck == IS_FULL_TIME)
>>>>>>> UC-3AddParttimeempwage
            {
                empHrs = 8;
            }
            else
            {
                empHrs = 0;
<<<<<<< HEAD
            }
            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Emp Wage : " + empWage);
        }
    }
}



=======

=======
                case IS_PART_TIME:
                    empHrs = 4;
                    break;
                case IS_FULL_TIME:
                    empHrs = 8;
                    break;
                default:
                    empHrs = 0;
                    break;
>>>>>>> UC-4Switchcasestatement
=======
            for (int day =0; day < NUM_OF_WORKING_DAYS; day++)
=======
            while (totalEmpHrs <= MAX_HRS_IN_MONTH && totalWorkingDays < NUM_OF_WORKING_DAYS)
>>>>>>> UC-6Totalwrkhrandday
            {
                totalWorkingDays++;
               
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
<<<<<<< HEAD
                empWage = empHrs * EMP_RATE_PER_HOUR;
                totalEmpWage += empWage;
                Console.WriteLine("Emp Wage of day : " + (day+1) + " is : " + empWage);
>>>>>>> UC-5Wagesformonth
=======
                totalEmpHrs += empHrs;
                Console.WriteLine("Day#:" + totalWorkingDays + "Emp Hours : " + empHrs);
>>>>>>> UC-6Totalwrkhrandday
            }
            int totalEmpWage = totalEmpHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Total Emp Wage : " + totalEmpWage);
        }
    }
}
>>>>>>> UC-3AddParttimeempwage
=======
    class EmployeeWageCompute
    {
        static void Main(string[] args)
        {
            //constants
            int IS_PRESENT = 1;

            //Predefined Random class for generating random values
            Random random = new Random();
            //Next method() 0-initial value,2-number of elements from 0
            int empcheck = random.Next(0, 2);
            //selection statement
            if (empcheck == IS_PRESENT)
                Console.WriteLine("Employee is present");
            else
                Console.WriteLine("Employee is Absent");
                Console.Read();
        }
    }
}
   
>>>>>>> e269f828627cecf9b9cdf2ea58e6066b8ed5baac

using System;
<<<<<<< HEAD
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageCompute058
{
    public class UC2_EmpWage
    {
        public static void EmpWage()
        {
            //Constants
            int IS_FULL_TIME = 1;
=======

namespace EmployeeCompute058
{
    public class UC3_PartTimeEmp
    {
        static void Main(String[] args)
        {
            //UC3 wage
            //Constants
            int IS_PART_TIME = 1;
            int IS_FULL_TIME = 2;
>>>>>>> UC-3AddParttimeempwage
            int EMP_RATE_PER_HOUR = 20;
            //Variables
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();
            //Computation
<<<<<<< HEAD
            int empCheck = random.Next(0, 2);
            if (empCheck == IS_FULL_TIME)
=======
            int empCheck = random.Next(0, 3);
            if (empCheck == IS_PART_TIME)
            {
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

            }
            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Employee Wage : " + empWage);
            Console.Read();
        }
    }
}
>>>>>>> UC-3AddParttimeempwage

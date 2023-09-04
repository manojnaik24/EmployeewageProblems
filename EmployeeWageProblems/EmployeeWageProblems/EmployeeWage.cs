using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblems
{
    public  class EmployeeWage
    {
        const int wagePerHour = 20,  isFullTime = 1;
        int fullDayHour = 0;
        public void Attendance()
        {
            Random random = new Random();

            int empCheck = random.Next(0,2);
            if (empCheck == isFullTime )
            {
                Console.WriteLine("Employee is Present");
                fullDayHour=8;
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
            int empWage = fullDayHour * wagePerHour;
            Console.WriteLine("Daily Wage is:" + empWage);
        }
    }
}

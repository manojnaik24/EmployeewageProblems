﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblems
{
    public  class EmployeeWage
    {
        const int wagePerHour = 20,  isFullTime = 1;
        int partTime = 4;
        int fullDayHour = 0;
        int perMoth = 20;

        public void Attendance()
        {
            Random random = new Random();

            int empCheck = random.Next(0,2);

            switch (empCheck)
            {  
                case isFullTime:
                Console.WriteLine("Employee is Present");
                fullDayHour=8;
                   
                    break;

                case int PartTime:
                    int emp = PartTime * wagePerHour;
                    Console.WriteLine("Part Time Wage:" + emp);

                    break;

                


                default:
                    Console.WriteLine("Employee is Absent");

                    break;

                    WagePerMoth();
            }
            void DailyWage(int wagePerHour)
            {
                int empWage = fullDayHour * wagePerHour;

                Console.WriteLine("Daily Wage is:" + empWage);
            }


           void WagePerMoth()
            {
                int PM = perMoth * wagePerHour * fullDayHour;
                Console.WriteLine("monthly wage is"+ PM);
            }

            


                
            
        }
    }
}

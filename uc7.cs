﻿



using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageComputation
{
    class EmployeeWage
    {

        const int IS_PART_TIME = 1;
        const int IS_FULL_TIME = 2;
        const int PER_HR = 20;
        const int MAX_WORKING_DAY = 20;
        const int MAX_HRS_IN_MONTH = 100;

        int empHrs = 0;
        int totalMonthlyWage = 0;
        int totalEmpHrs = 0;
        int totalWorkingDays = 0;


        public void MonthWage()
        {
            if (totalEmpHrs < MAX_HRS_IN_MONTH &&
                    totalWorkingDays < MAX_WORKING_DAY)
            {
                totalWorkingDays++;
                Random rd = new Random();
                int empCheck = rd.Next(0, 3);
                empHrs = empCheck switch
                {
                    IS_FULL_TIME => 8,
                    IS_PART_TIME => 4,
                };
                
                totalEmpHrs += empHrs;
            }
            totalMonthlyWage = totalEmpHrs * PER_HR;
            Console.WriteLine("Total monthly wage:" + totalMonthlyWage);
        }
    }
}
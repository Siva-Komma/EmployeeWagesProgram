﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWagesProgram
{
    public class EmployeeWages
    {
        public static void CheckingEmployeeWages()
        {
            int Emp_Present = 1;
            int Emp_Rate_Per_Hour = 20;
            int Is_Part_Time = 2;
            int empHrs = 0;
            int EmpWage = 0;

            Random random = new Random();
            int empCheck = random.Next(3);
            switch (empCheck)
            {
                case 0:
                    empHrs = 8;
                    break;
                case 1:
                    empHrs = 4;
                    break;
                case 2:
                    empHrs = 0;
                    break;
            }
            EmpWage = empHrs * Emp_Rate_Per_Hour;
            Console.WriteLine("Emp Wage: " + EmpWage);
        }
    }
}

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
            int empHrs = 0;
            int EmpWage = 0;

            Random random = new Random();
            int empCheck = random.Next(2);
            if (empCheck == Emp_Present)
            {
                empHrs = 8;
            }
            else
            {
                empHrs = 0;
            }
            EmpWage = empHrs * Emp_Rate_Per_Hour;
            Console.WriteLine("Emp Wage: " + EmpWage);
        }
    }
}

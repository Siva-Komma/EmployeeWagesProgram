﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWagesProgram
{
    public class EmployeeWages
    {
        public const int Num_of_Working_Days = 20;
        public static void CheckingEmployeeWages()
        {
            int Emp_Present = 1;
            int Emp_Rate_Per_Hour=20;
            int Is_Part_Time = 2;
            int empHrs = 0;
            int EmpWage = 0;
            int TotalEmpWage = 0;

            for (int day = 0; day < Num_of_Working_Days; day++)
            {
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
                TotalEmpWage += EmpWage;
                Console.WriteLine("Emp Wage: " + EmpWage);
            }
            Console.WriteLine("Toayal Emp Wage: " + TotalEmpWage);
        }
    }
}

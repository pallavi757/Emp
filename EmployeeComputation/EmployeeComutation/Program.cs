// See https://aka.ms/new-console-template for more information

using System;
namespace EmployeeComputation
{
    //UC6
        class Employee
        {
            
            public const int Part_time = 1;
            public const int Full_time = 2;
            public const int Emp_rate_per_hrs = 20;
            public const int Num_Of_Working_Days = 20;

            static void Main(string[] args)
            {
               // Console.WriteLine("Welcome to Employee Wage Computation Program");
                int empHrs = 0;
                int empWage = 0;
                int totalEmpwage = 0;
                for (int day = 0; day < Num_Of_Working_Days; day++)
                {
                    Random random = new Random();
                    int empCheck = random.Next(0, 3);
                    switch (empCheck)
                    {
                        case Part_time:
                            empHrs = 4;
                            Console.WriteLine("Employee is Present");
                            Console.WriteLine("Employee is Part time");
                            break;
                        case Full_time:
                            empHrs = 8;
                            Console.WriteLine("Employee is Present");
                            Console.WriteLine("Employee is Full time");
                            break;
                        default:
                            empHrs = 0;
                            Console.WriteLine("Employee is Absent");
                            break;
                    }
                    empWage = (Emp_rate_per_hrs * empHrs);
                    totalEmpwage += empWage;
                    Console.WriteLine("Daily emp wage: " + empWage);
                }
                Console.WriteLine("Total Emp Wage: " + totalEmpwage);
            }
        }
    }



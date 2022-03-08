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
        public const int Max_Hrs_Month = 100;
        static void Main(string[] args)
        {
            //Console.WriteLine("Welcome to Employee Wage Computation Program");
            int empWage = 0;
            int empHrs = 0;
            int totalEmpHr = 0;
            int totalworkingDays = 0;
            while (totalEmpHr <= Max_Hrs_Month && totalworkingDays < Num_Of_Working_Days)
            {
                totalworkingDays++;
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
                        Console.WriteLine("Employee is Present");
                        Console.WriteLine("Employee is Full time");
                        empHrs = 8;
                        break;
                    default:
                        Console.WriteLine("Employee is Absent");
                        empHrs = 0;
                        break;
                }

                totalEmpHr += empHrs;
                Console.WriteLine("Days = " + totalworkingDays + " EmpHRS " + empHrs);

                empWage = (Emp_rate_per_hrs * empHrs);
                Console.WriteLine("Daily wage " + empWage);
            }
            int totalEmpwage = (Emp_rate_per_hrs * totalEmpHr);
            Console.WriteLine("Total Emp Wage: " + totalEmpwage);
        }

        
     }
    }



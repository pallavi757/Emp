

using System;
namespace EmployeeComputation
{
    //UC7
        class Employee
        {
           private float Emp_rate_per_hrs = 20;
           public int FullTime_WorkingHrs_PerDay=8;
           public int PartTime_WorkingHrs_PerDay=4;
           public const int Part_time = 1;
           public const int Full_time = 2;
           public  int Num_Of_Working_Days = 20;
           public  int Max_Hrs_Month = 100;
           public float empWage = 0;
           public float totalEmpwage = 0;

        public Employee(int  Emp_rate_per_hrs,int FullTime_WorkingHrs_PerDay,int PartTime_WorkingHrs_PerDay,int Num_Of_Working_Days,int Max_Hrs_Month)//variable constructor
        {
            this.Emp_rate_per_hrs=Emp_rate_per_hrs;
            this.FullTime_WorkingHrs_PerDay = FullTime_WorkingHrs_PerDay;
            this.PartTime_WorkingHrs_PerDay=PartTime_WorkingHrs_PerDay;
            this.Max_Hrs_Month=Max_Hrs_Month;
            this.Num_Of_Working_Days=Num_Of_Working_Days;
        }
        private int IsEmpoyeePresent()
        {
             Random random = new Random();
             int empCheck = random.Next(0, 3);
             return empCheck;
        }
        
        public void CalculateWage()
        {
            int DayNumber = 1;
            int empHrs = 0;
            int totalEmpHr = 0;
       
         while(DayNumber<=Num_Of_Working_Days&& totalEmpHr<=Max_Hrs_Month)
            {
              
                switch (IsEmpoyeePresent())
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

                empWage = (Emp_rate_per_hrs * empHrs);
                totalEmpwage+=empWage;
                DayNumber++;
                totalEmpHr += empHrs;
          }
               
               Console.WriteLine("Total Working Days: " + (DayNumber-1)+"\nTotal Working Hours:" + totalEmpHr);
        }
         static void Main(string[] args)
         {
            Console.WriteLine("Welcome to Employee Wage Computation Program");
            Employee employee=new Employee(20,8,4,100,20);
            employee.CalculateWage();
        
         }
    }
}



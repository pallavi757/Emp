

using System;
namespace EmployeeComputation
{
    //UC8
    class Company
    {
           public float Emp_rate_per_hrs = 20;
           public int FullTime_WorkingHrs_PerDay=8;
           public int PartTime_WorkingHrs_PerDay=4;
           public  int Num_Of_Working_Days = 20;
           public  int Max_Hrs_Month = 100;
           public string companyname;
        public Company(string companyname,int  Emp_rate_per_hrs,int FullTime_WorkingHrs_PerDay,int PartTime_WorkingHrs_PerDay,int Num_Of_Working_Days,int Max_Hrs_Month)
        {
            this.companyname = companyname; 
            this.Emp_rate_per_hrs=Emp_rate_per_hrs;
            this.FullTime_WorkingHrs_PerDay = FullTime_WorkingHrs_PerDay;
            this.PartTime_WorkingHrs_PerDay=PartTime_WorkingHrs_PerDay;
            this.Max_Hrs_Month=Max_Hrs_Month;
            this.Num_Of_Working_Days=Num_Of_Working_Days;
        }

     }
    class Employee
    {

        private const int Part_time = 1;
        private const int Full_time = 2;
        private float empWage = 0;

        private float totalEmpwage = 0;
        private Dictionary<string, Company> Companies = new Dictionary<string, Company>();

          
    private void Addcompany(string companyname,int Emp_rate_per_hrs,int FullTime_WorkingHrs_PerDay,int PartTime_WorkingHrs_PerDay,int Max_Hrs_Month,int Num_Of_Working_Days)
          {
            Company company = new Company(companyname, Emp_rate_per_hrs, FullTime_WorkingHrs_PerDay, PartTime_WorkingHrs_PerDay, Max_Hrs_Month, Num_Of_Working_Days);
           Companies.Add(companyname.ToLower(), company);   

          }

        //public Employee(int  Emp_rate_per_hrs,int FullTime_WorkingHrs_PerDay,int PartTime_WorkingHrs_PerDay,int Num_Of_Working_Days,int Max_Hrs_Month)//variable constructor
        //{
        //    this.Emp_rate_per_hrs=Emp_rate_per_hrs;
        //    this.FullTime_WorkingHrs_PerDay = FullTime_WorkingHrs_PerDay;
        //    this.PartTime_WorkingHrs_PerDay=PartTime_WorkingHrs_PerDay;
        //    this.Max_Hrs_Month=Max_Hrs_Month;
        //    this.Num_Of_Working_Days=Num_Of_Working_Days;
        //}
        private int IsEmpoyeePresent()
        {
            return new Random().Next(0, 3);
             //Random random = new Random();
             //int empCheck = random.Next(0, 3);
             //return empCheck;
        }
        
        public void CalculateWage(string companyname)
        {
            int DayNumber = 0;
            int empHrs = 0;
            int totalEmpHr = 0;
            if (!Companies.ContainsKey(companyname.ToLower()))
                throw new ArgumentNullException("company does not exist");
            Companies.TryGetValue(companyname.ToLower(), out Company company);
       
         while(DayNumber<=company.Num_Of_Working_Days && totalEmpHr<=company.Max_Hrs_Month)
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

                empWage = empHrs * company.Emp_rate_per_hrs;
                totalEmpwage+=empWage;
                DayNumber++;
                totalEmpHr += empHrs;
          }
               
               Console.WriteLine("\nCompany name: " + companyname);
               Console.WriteLine("Total Working Days: " + (DayNumber - 1) + "\nTotal Working Hours:" + totalEmpHr);
        }
         static void Main(string[] args)
         {
            Console.WriteLine("Welcome to Employee Wage Computation Program");
            Employee employee=new Employee();
            employee.Addcompany("Tata",20,8,4,100,20);
            employee.Addcompany("Wipro", 20, 8, 4, 100, 20);
            employee.CalculateWage("Tata");
            employee.CalculateWage("Wipro");
        }
    }
}



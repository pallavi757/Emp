// See https://aka.ms/new-console-template for more information

class Employee
{
    static void Main(String[] args)
    {
        int Full_time = 1;//constant
        int Emp_rate_per_hrs = 20;//varible
        int empHrs = 0;
        int empWage = 0;
        Random random = new Random();//comutaion
        int empCheck = random.Next(0, 2);
        if (empCheck == Full_time)
        {
            empHrs = 8;//Console.WriteLine("Employee is Present");
        }
        else
        {
            empHrs = 0; //Console.WriteLine("Employee is Absent");
        }
        empWage = empHrs * Emp_rate_per_hrs;
        Console.WriteLine("Emp Wage:" + empWage);
    }
}




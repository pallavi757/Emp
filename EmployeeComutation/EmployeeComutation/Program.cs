// See https://aka.ms/new-console-template for more information

class Employee
{
    static void Main(String[] args)
    {
        int Present = 1;
        int Full_time = 1;//constant
        int Emp_rate_per_hrs = 20;//varible
        int empHrs = 0;
        int empWage = 0;
        Random random = new Random();//comutaion
        Random ram = new Random();

        int empCheck = random.Next(0, 3);
        int empTime = ram.Next(0, 3);
        if (empCheck == Present)
        {
            if (empTime == Full_time)
            {
                Console.WriteLine("Employee is Present");
                empHrs = 8;
            }
            else
            {
                Console.WriteLine("Employee is Part time present");
                empHrs = 4;
            }
        }
        else
        {
            Console.WriteLine("Employee is absent  ");
            empHrs = 0;
        }
       
       //Console.WriteLine("Emloyee is absent");
        empWage = empHrs * Emp_rate_per_hrs;
        Console.WriteLine("Emp Wage:" + empWage);
    }
}


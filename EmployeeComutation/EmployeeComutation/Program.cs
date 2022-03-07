// See https://aka.ms/new-console-template for more information

class Employee
{
    static void Main(String[] args)
    {
        int Full_time = 1;//constant
        Random random = new Random();//comutaion
        int empCheck = random.Next(0, 2);
        if (empCheck == Full_time)
        {
            Console.WriteLine("Employee is Present");
        }
        else
        {
            Console.WriteLine("Employee is Absent");
        }

    }
}


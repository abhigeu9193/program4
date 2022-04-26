// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
class program4
{
    public const int IS_PART_TIME = 1;
    public const int IS_FULL_NUMBER = 2;
    public const int EMP_RATE_PER_HOUR = 60;
    static void Main(string[] args)
    {
        int empHrs = 0;
        int empWage = 0;
        Random random = new Random();
        int empCheck = random.Next(0, 2);
        Console.WriteLine(value: empCheck);

        switch (empCheck)
        {
            case IS_PART_TIME:
                empHrs = 4;
                break;
            case IS_FULL_NUMBER:
                empHrs = 8;
                break;
            default:
                empHrs = 0;

                break;
        }
        empWage = empHrs * EMP_RATE_PER_HOUR;
        Console.WriteLine("Emp Wage :" + empWage);
        Console.ReadKey();


    }
}

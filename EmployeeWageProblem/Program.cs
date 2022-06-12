using System;

namespace EmployeeWageProblem
{
    internal class Program
    {

        public const int IsPartTime = 2;
        public const int IsFullTime = 1;
        public const int IsAbsent = 0;
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Employee Wage Computation Program");

            int Totalwage = 0;
            int WagePerHr = 20;
            int PartTimeHr = 4;
            int FullTimeHr = 8;
            int NumberOfDaysPerMonth = 20;

            for (int i = 0; i < NumberOfDaysPerMonth; i++)
            {
                Random random = new Random();
                int number = random.Next(0, 3);
                switch (number)
                {
                    case IsFullTime:
                        Console.WriteLine("Employee is Full Time");
                        Totalwage = Totalwage + WagePerHr * FullTimeHr;
                        break;
                    case IsPartTime:
                        Console.WriteLine("Employee is working part time");
                        Totalwage = Totalwage + WagePerHr * PartTimeHr;

                        break;
                    case IsAbsent:
                        Console.WriteLine("Employee is Absent");
                        break;


                }
                Console.WriteLine("Employee's Total Wage is" + Totalwage);

            }

        }
    }
}

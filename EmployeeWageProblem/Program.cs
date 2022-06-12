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

          
            int WagePerHr = 20;
            
            int Maxhours = 100;
            int totalworkingDays = 0;
            int Emphrs=0;
            int NumberOfDaysPerMonth = 20;
            int TotalEmpHrs = 0;

            while (totalworkingDays< NumberOfDaysPerMonth && TotalEmpHrs<=Maxhours )
            {
                totalworkingDays++;
                Random random = new Random();
                int number = random.Next(0, 3);
                switch (number)
                {
                    case IsFullTime:
                        Console.WriteLine("Employee is Full Time");
                        Emphrs = 8;

                        break;
                    case IsPartTime:
                        Console.WriteLine("Employee is working part time");
                        Emphrs = 4;
                        break;
                    case IsAbsent:
                        Console.WriteLine("Employee is Absent");
                        break;

                        

                }

                TotalEmpHrs += Emphrs;
                Console.WriteLine("Days " + totalworkingDays + "EmpHrs " + Emphrs);
                int TotalEmpWage = TotalEmpHrs * WagePerHr;
                Console.WriteLine("Total Emp Wage is" + TotalEmpWage);

              

            }

        }
    }
}

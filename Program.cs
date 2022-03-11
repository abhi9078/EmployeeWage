using System;

namespace EmployeeWages
{
    internal class Program
    {
        public static void UC1()
        {
            Console.WriteLine("Wlcome to UC_1");
            Random random = new Random();
            int num = random.Next(0, 2);
            if (num == 0)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }

        }

        public static void UC2()
        {
            Console.WriteLine("Wlcome to UC_2");
            int totalWorkingHour = 8;
            int wagePerHour = 20;
            int dailyWage = 0;
            Random random = new Random();
            int num = random.Next(0, 2);
            if (num == 0)
            {
                Console.WriteLine("Empoloyee is Present");
                dailyWage = totalWorkingHour * wagePerHour;
                Console.WriteLine("Total Daily wage is: " + dailyWage);
            }
            else
            {
                Console.WriteLine("Employee is Absent");
                Console.WriteLine("Total Daily wage is: " + dailyWage);
            }

        }


        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Welcome to Employeewages problem ");
            Program.UC1();
            Program.UC2();
        }
    }
}

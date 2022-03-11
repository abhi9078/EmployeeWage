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

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Welcome to Employeewages problem ");
            Program.UC1();
        }
    }
}

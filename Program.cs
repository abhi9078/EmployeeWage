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

        public static void UC3()
        {
            Console.WriteLine("Wlcome to UC_3");
            int totalWorkingHour = 8;
            int partTimeHour = 4;
            int wagePerHour = 20;
            int dailyWage = 0;
            Random random = new Random();
            int num = random.Next(0, 3);
            if (num == 0)
            {
                Console.WriteLine("Empoloyee is Present");
                dailyWage = totalWorkingHour * wagePerHour;
                Console.WriteLine("Total Daily wage is: " + dailyWage);
            }
            else if (num == 1)
            {
                Console.WriteLine("Employee is doing Parttime");
                dailyWage = partTimeHour * wagePerHour;
                Console.WriteLine("Total Daily wage is: " + dailyWage);
            }
            else
            {
                Console.WriteLine("Employee is Absent");
                Console.WriteLine("Total Daily wage is: " + dailyWage);

            }
        }

        public static void UC4()
        {
            Console.WriteLine("Wlcome to UC_4");
            int isFullTime = 1;
            int isPartTime = 2;
            int totalWorkingHour, wagePerHour = 20, totalWage = 0;

            Random random = new Random();
            int randomCheck = random.Next(0, 3);
            switch (randomCheck)
            {
                case 1:
                    totalWorkingHour = 8;
                    Console.WriteLine("Employee is Present");
                    break;
                case 2:
                    totalWorkingHour = 4;
                    Console.WriteLine("Employee is doing parttime:");
                    break;
                default:
                    totalWorkingHour = 0;
                    Console.WriteLine("Employee is absent");
                    break;
            }
            totalWage = wagePerHour * totalWorkingHour;
            Console.WriteLine("Total wage is: " + totalWage);

        }

        public static void UC5()
        {
            Console.WriteLine("Wlcome to UC_5");
            int isFullTime = 1;
            int isPartTime = 2;
            int totalWorkingHour = 0, wagePerHour = 20, totalWage = 0;
            int totalWorkingDay = 1, empHrs;


            while (totalWorkingDay < 20)
            {
                Random random = new Random();
                int randomCheck = random.Next(0, 3);

                switch (randomCheck)
                {
                    case 1:
                        empHrs = 8;
                        Console.WriteLine("Employee is Present");
                        break;
                    case 2:
                        empHrs = 4;
                        Console.WriteLine("Employee is doing parttime:");
                        break;
                    default:
                        empHrs = 0;
                        Console.WriteLine("Employee is absent");
                        break;
                }
                totalWorkingDay++;
                totalWorkingHour = totalWorkingHour + empHrs;
            }
            totalWage = wagePerHour * totalWorkingHour;
            Console.WriteLine("Total wage is: " + totalWage);

        }


        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Welcome to Employeewages problem ");
            Program.UC1();
            Program.UC2();
            Program.UC3();
            Program.UC4();
            Program.UC5();
        }
    }
}

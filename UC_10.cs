using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWages
{
    internal class UC_10
    {
        private string company;
        private int empRatePerHour;
        private int workingHourLimit;
        private int empWorkingDays;
        private int totalEmployeeWage;

        public UC_10(string company, int empRatePerHour, int workingHourLimit, int empWorkingDays)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.workingHourLimit = workingHourLimit;
            this.empWorkingDays = empWorkingDays;

        }

        public void setTotalEmpWage(int totalEmpWage)
        {
            this.totalEmployeeWage = totalEmpWage;
        }

        public string toString()
        {
            return "Total Employee Wage for company :" + this.company + " is " + this.totalEmployeeWage;
        }

    }

    public class EmpWage
    {
        public const int isPartTime = 2;
        public const int isFullTime = 1;

        private int numOfCompany = 0;
        private UC_10[] companyEmpWageArray;

        public EmpWage()
        {
            this.companyEmpWageArray = new UC_10[5];
        }

        public void addCompanyEmpwage(string company, int empRatePerHour, int workingHourLimit, int empWorkingDays)
        {
            companyEmpWageArray[this.numOfCompany] =
                new UC_10(company, empRatePerHour, workingHourLimit, empWorkingDays);
            numOfCompany++;
        }


        private int computeEmpwage(UC_10 uC_10)
        {
            int empHrs = 0;
            int totalWorkingDays = 0;
            int totalWorkingHour = 0;
            int present = 0, halftime = 0, absent = 0;

            while (totalWorkingDays <= uC_10.empWorkingDays && totalWorkingHour <= UC_10.workingHourLimit)
            {
                totalWorkingDays++;
                Random random = new Random();
                int randomCheck = random.Next(3);
                switch (randomCheck)
                {
                    case isFullTime:
                        empHrs = 8;
                        present++;
                        break;
                    case isPartTime:
                        empHrs = 4;
                        halftime++;
                        break;
                    default:
                        empHrs = 0;
                        absent++;
                        break;
                }
                totalWorkingHour = totalWorkingHour + empHrs;
                Console.WriteLine("Days: " + totalWorkingDays + "Emp Hours is: " + empHrs);
            }
            return totalWorkingHour * uC_10.empRatePerHour;

        }

        public void computeEmpWage()
        {
            for (int i = 0; i < numOfCompany; i++)
            {
                companyEmpWageArray[i].setTotalEmpWage(this.computeEmpWage(this.companyEmpWageArray[i]));
                Console.WriteLine(this.companyEmpWageArray[i].toString());
            }
        }
    }
}

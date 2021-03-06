using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public interface IEmployee
    {
        public void getWage();
        public void addEmployeeWage(string companyName, int wagePerHour, int totalWorkingDays, int maxHrsWorked);
    }
    public class CompanyEmpWage
    {
        const int ISPRESENT = 1;
        const int ISPARTTIME = 2;
        readonly string companyName;
        readonly int wagePerHour;
        readonly int totalWorkingDays;
        readonly int maxHrsWorked;

        public CompanyEmpWage(string companyName, int wagePerHour, int totalWorkingDays, int maxHrsWorked)
        {
            this.companyName = companyName;
            this.wagePerHour = wagePerHour;
            this.totalWorkingDays = totalWorkingDays;
            this.maxHrsWorked = maxHrsWorked;
        }
        public void ComputingWage()
        {
            static int getworkhrs()
            {
                //VARIABLES
                int workDayHours = 0;

                Random random = new Random();
                int employeeCheck = random.Next(0, 3);
                switch (employeeCheck)
                {
                    case ISPRESENT:
                        //Console.WriteLine("Employee is present");
                        workDayHours = 8;
                        return workDayHours;
                    case ISPARTTIME:
                        //Console.WriteLine("Employee is part-time working");
                        workDayHours = 4;
                        //I have changed the workDayHours for part time working to 4 hrs.
                        return workDayHours;
                    default:
                        //Console.WriteLine("Employee is absent");
                        workDayHours = 0;
                        return workDayHours;
                }
            }
            int totalWorkingHrs = 0;
            int workingDays = 1;
            int totalWage = 0;
            int workingHrs = 0;

            while (workingDays <= totalWorkingDays && totalWorkingHrs < maxHrsWorked)
            {
                workingHrs = getworkhrs();
                totalWage += wagePerHour * workingHrs;

                totalWorkingHrs += workingHrs;
                workingDays++;
            }
            Console.WriteLine($"Employee from {companyName} earns {totalWage} ");
        }
    }
}

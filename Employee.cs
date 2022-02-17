using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class Employee
    {
        const int ISPRESENT = 1;
        const int ISPARTTIME = 2;
        readonly string companyName;
        readonly int wagePerHour;
        readonly int totalWorkingDays;
        readonly int maxHrsWorked;

        public Employee(string companyName, int wagePerHour, int totalWorkingDays, int maxHrsWorked)
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
            IDictionary<int, int> dailyWage = new Dictionary<int, int>();

            while (workingDays <= totalWorkingDays && totalWorkingHrs < maxHrsWorked)
            {
                workingHrs = getworkhrs();
                dailyWage[workingDays] = workingHrs * wagePerHour;
                totalWage += wagePerHour * workingHrs;
                Console.WriteLine($"Employee dailyWage is {dailyWage[workingDays]} & Total wage till this day is {totalWage}");
                totalWorkingHrs += workingHrs;
                workingDays++;
            }
            Console.WriteLine($"Employee from {companyName} earns {totalWage} ");
        }
    }

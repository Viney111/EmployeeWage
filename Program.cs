using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal class EmployeeWage
    {
        static int getworkhrs()
        {
            //CONSTANTS
            const int ISPRESENT = 1;
            const int ISPARTTIME = 2;
            const int ISABSENT = 0;
            //VARIABLES
            int workDayHours = 0;

            Random random = new Random();
            int employeeCheck = random.Next(0, 3);
            switch (employeeCheck)
            {
                case ISPRESENT:
                    Console.WriteLine("Employee is present");
                    workDayHours = 8;
                    return workDayHours;
                    break;
                case ISPARTTIME:
                    Console.WriteLine("Employee is part-time working");
                    workDayHours = 4;
                    //I have changed the workDayHours for part time working to 4 hrs.
                    return workDayHours;
                    break;
                default:
                    Console.WriteLine("Employee is absent");
                    workDayHours = 0;
                    return workDayHours;
                    break;
            }
        }
        static void Main(string[] args)
        {
            //CONSTANTS
            const int WAGEPERHOUR = 20;
            const int TOTALWORKINGDAYS = 20;
            const int MAXHRSWORKED = 100;

            //VARIABLES
            int workingHrs = 0;
            int totalWorkingHrs = 0;
            int workingDays = 1;
            int totalWage = 0;
            int i = 0;
            int[] workingDaysArray = new int[20];
            int[] dailyWageArray = new int[20];
            int[] totalWageArray = new int[20];

            while (workingDays <= TOTALWORKINGDAYS && totalWorkingHrs < MAXHRSWORKED)
            {
                workingHrs = getworkhrs();
                workingDaysArray[i] = workingDays;
                dailyWageArray[i] = WAGEPERHOUR * workingHrs;
                totalWage = totalWage + WAGEPERHOUR * workingHrs;
                totalWageArray[i] = totalWage;
                totalWorkingHrs = totalWorkingHrs + workingHrs;
                workingDays++;
                i++;
 
            }
            int employeeWage = totalWorkingHrs * WAGEPERHOUR;
            Console.WriteLine($"Employee earns {employeeWage}");
            Console.WriteLine(String.Join(" ", workingDaysArray));
            Console.WriteLine(String.Join(" ",dailyWageArray));
            Console.WriteLine(String.Join(" ", totalWageArray));
            Console.ReadLine();

        }
    }
}
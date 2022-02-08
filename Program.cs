using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal class EmployeeWage
    {
        static void Main(string[] args)
        {
            const int ISPRESENT = 1;
            const int ISPARTTIME = 2;
            const int ISABSENT = 0;
            const int WAGEPERHOUR = 20;
            int workingHours = 8;

            Random random = new Random();
            int employeeCheck = random.Next(0, 3);
            switch (employeeCheck)
            {
                case ISPRESENT:
                    //Console.WriteLine("Employee is present");
                    workingHours = 8;
                    break;
                case ISPARTTIME:
                    //Console.WriteLine("Employee is part-time working");
                    workingHours = 8;
                    break;
                default:
                    //Console.WriteLine("Employee is absent");
                    workingHours = 0;
                    break;
            }
            int employeeWage = workingHours * WAGEPERHOUR;
            Console.WriteLine($"Employee earns {employeeWage}");
            Console.ReadLine();

        }
    }
}
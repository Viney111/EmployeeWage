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
            const int ISABSENT = 0;
            const int WAGEPERHOUR = 20;
            int workingHours = 8;
            

            Random random = new Random();
            int employeeCheck = random.Next(0, 2);
            if (employeeCheck == ISPRESENT)
            {
                Console.WriteLine("Employee is Present");
                workingHours = 8;

            }
            else
            {
                Console.WriteLine("Employee is absent");
                workingHours = 0;
            }
            int employeeWage = workingHours * WAGEPERHOUR;
            Console.WriteLine($"Employee earns {employeeWage}");

        }
    }
}
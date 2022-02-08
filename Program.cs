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
            Random random = new Random();
            int employeeCheck = random.Next(0, 2);
            if (employeeCheck == ISPRESENT)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is absent");
            }
            Console.ReadLine();

        }
    }
}
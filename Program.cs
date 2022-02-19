
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public class EmployeeWage
    {
        static void Main(string[] args)
        {
            IEmployee employee = new EmpWageBuilderList();
            employee.addEmployeeWage("TATA",20,20,100);
            employee.addEmployeeWage("HYUNDAI", 25, 18, 90);
            employee.addEmployeeWage("FORD", 30, 19, 80);
            employee.addEmployeeWage("TOYOTA", 30, 21, 110);
            employee.addEmployeeWage("MAHINDRA", 18, 25, 120);

            employee.getWage();
        }
    }
}
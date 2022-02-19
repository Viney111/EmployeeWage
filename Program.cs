
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
            EmpWageBuilderList empWageBuilderArray = new EmpWageBuilderList();
            empWageBuilderArray.addEmployeeWage("TATA",20,20,100);
            empWageBuilderArray.addEmployeeWage("HYUNDAI", 25, 18, 90);
            empWageBuilderArray.addEmployeeWage("FORD", 30, 19, 80);
            empWageBuilderArray.addEmployeeWage("TOYOTA", 30, 21, 110);
            empWageBuilderArray.addEmployeeWage("MAHINDRA", 18, 25, 120);

            empWageBuilderArray.getWage();
        }
    }
}

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
            EmpWageBuilderArray empWageBuilderArray = new EmpWageBuilderArray(5);
            empWageBuilderArray.addEmployeeWage("TATA", 20, 15, 100);
            empWageBuilderArray.addEmployeeWage("MARUTI", 25, 20, 80);
            empWageBuilderArray.addEmployeeWage("HYUNDAI", 20, 22, 90);
            empWageBuilderArray.addEmployeeWage("TESLA", 35, 20, 110);
            empWageBuilderArray.addEmployeeWage("KIA", 30, 18, 80);
            empWageBuilderArray.getWage();
        }
    }
}
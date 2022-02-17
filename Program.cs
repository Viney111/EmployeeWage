
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
            Employee e1 = new Employee("TATA",30, 21, 100);
            e1.ComputingWage();
            Employee e2 = new Employee("KORLOY",40, 25, 120);
            e2.ComputingWage();
        }
    }
}

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
            EmpWage_Builder_Object dmart = new EmpWage_Builder_Object("DMart", 20, 20, 100);
            EmpWage_Builder_Object reliance = new EmpWage_Builder_Object("Reliance", 25, 18, 120);
            dmart.ComputingWage();
            reliance.ComputingWage();
            
        }
    }
}
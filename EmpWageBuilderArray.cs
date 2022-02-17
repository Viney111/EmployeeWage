using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal class EmpWageBuilderArray
    {
        private CompanyEmpWage[] empWageArray;

        public EmpWageBuilderArray(int size)
        {
            this.empWageArray = new CompanyEmpWage[size];
        }
        int i = 0;
        public void addEmployeeWage(string companyName, int wagePerHour, int totalWorkingDays, int maxHrsWorked)
        {
            empWageArray[i] = new CompanyEmpWage(companyName,wagePerHour,totalWorkingDays,maxHrsWorked);
            i++;
        }
        public void getWage()
        {
            for(int j = 0; j < empWageArray.Length; j++)
            {
                empWageArray[j].ComputingWage();
            }
        }
        
       
    } 
}

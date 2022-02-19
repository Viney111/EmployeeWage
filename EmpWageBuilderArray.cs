using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal class EmpWageBuilderList : IEmployee
    {
        private List<CompanyEmpWage> empWageList;

        public EmpWageBuilderList()
        {
            this.empWageList = new List<CompanyEmpWage>();
        }
        public void addEmployeeWage(string companyName, int wagePerHour, int totalWorkingDays, int maxHrsWorked)
        {
            empWageList.Add(new CompanyEmpWage(companyName,wagePerHour, totalWorkingDays, maxHrsWorked));
        }
        public void getWage()
        {
            foreach (var emp in empWageList)
            {
                emp.ComputingWage();
            }
        }
        
       
    } 
}

using P03.Detail_Printer.Contracts;
using System.Collections.Generic;

namespace P03.DetailPrinter
{
    public class DetailsPrinter
    {
        private IList<Employee> employees;

        public DetailsPrinter(IList<Employee> employees)
        {
            this.employees = employees;
        }

        public void PrintDetails()
        {
            foreach (IEmployee employee in employees)
            {
                employee.PrintDetails();
            }
        }
    }
}
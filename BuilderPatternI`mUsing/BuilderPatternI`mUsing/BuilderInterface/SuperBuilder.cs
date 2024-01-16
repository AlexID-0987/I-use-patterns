using BuilderPatternI_mUsing.EmployeBuilder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuilderPatternI_mUsing.BuilderInterface
{
    public class SuperBuilder:IEmploeeBuilder
    {
        private ReportEmploye reportEmploye;
        private readonly IEnumerable<Employee> employees;
        public SuperBuilder(IEnumerable<Employee> _emp)
        {
            employees = _emp;
            reportEmploye = new ReportEmploye();
        }
        public void BuilderHeader()
        {
            reportEmploye.Header = $"Emploees: {DateTime.Now}\n";
            reportEmploye.Header +=
                "\n\t\t-----------------------------------------------\n"
            +"\n\t--------------------------------------------------------------\n";
        }
        public void BuilderBody()
        {
            reportEmploye.Body =
                string.Join(Environment.NewLine,
                employees.Select(e => $"\t\tEmploee {e.Name}\t\t{e.Salary}"));
        }
        public void BuilderFooter()
        {
            reportEmploye.Footer =
                "\n\t\t--------------------------------------\n";
            reportEmploye.Footer +=
                $"\n\t\tTotal Emploees {employees.Count()}" +
                $"\n\t\tTotal summa{employees.Sum(a => a.Salary)}";
        }
        public ReportEmploye GetReport()
        {
            ReportEmploye report = reportEmploye;
            reportEmploye = new ReportEmploye();
            return report;
        }
    }
}

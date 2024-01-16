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
                "\n-----------------------------------------------\n"
            +"\n-----------------------------------------------------\n";
        }
        public void BuilderBody()
        {
            reportEmploye.Body =
                string.Join(Environment.NewLine,
                employees.Select(e => $"Emploee {e.Name}\t\t{e.Salary}"));
        }
        public void BuilderFooter()
        {
            reportEmploye.Footer =
                "\n--------------------------------------\n";
            reportEmploye.Footer +=
                $"\nTotal Emploees {employees.Count()}" +
                $"]nTotal summa{employees.Sum(a => a.Salary)}";
        }
        public ReportEmploye GetReport()
        {
            ReportEmploye report = reportEmploye;
            reportEmploye = new ReportEmploye();
            return report;
        }
    }
}

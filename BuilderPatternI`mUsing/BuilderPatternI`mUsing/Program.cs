using BuilderPatternI_mUsing.BuilderInterface;
using BuilderPatternI_mUsing.EmployeBuilder;
using System;
using System.Collections.Generic;

namespace BuilderPatternI_mUsing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee{Name="Alex", Salary=567457},
                new Employee{Name="Fred", Salary=54654}
            };
            SuperBuilder reportEmploye = new SuperBuilder(employees);
            EmployeDirector employeDirector = new EmployeDirector(reportEmploye);
            employeDirector.Build();
            var report = reportEmploye.GetReport();
            Console.WriteLine(report);
            Console.ReadKey();

        }
    }
}

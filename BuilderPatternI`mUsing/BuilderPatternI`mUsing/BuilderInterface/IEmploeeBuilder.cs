using BuilderPatternI_mUsing.EmployeBuilder;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPatternI_mUsing.BuilderInterface
{
    public interface IEmploeeBuilder
    {
        void BuilderHeader();
        void BuilderBody();
        void BuilderFooter();
        ReportEmploye GetReport();
    }
}

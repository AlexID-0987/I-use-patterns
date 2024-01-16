using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPatternI_mUsing.BuilderInterface
{
    public class EmployeDirector
    {
        private readonly IEmploeeBuilder emploeeBuilder;
        public EmployeDirector(IEmploeeBuilder builder)
        {
            emploeeBuilder = builder;
        }
        public void Build()
        {
            emploeeBuilder.BuilderHeader();
            emploeeBuilder.BuilderBody();
            emploeeBuilder.BuilderFooter();
        }
    }
}

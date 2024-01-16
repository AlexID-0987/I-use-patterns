using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPatternI_mUsing.EmployeBuilder
{
    public class ReportEmploye
    {
        public string Header { get; set;}
        public string Body { get; set;}
        public string Footer { get; set; }
        public override string ToString() =>
               new StringBuilder()
                .Append(Header)
                .Append(Body)
                .Append(Footer)
                .ToString();

        
    }
}

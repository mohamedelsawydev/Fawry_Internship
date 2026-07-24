using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Fawry_Internship.Models
{
    public class Fine
    {
        public string PlateNumber { get; set; }
        public decimal Amount { get; set; }

        public List<Violation>  Violations { get; set; }= new List<Violation>();



        override public string ToString()
        {

            var s= $"Traffic fine for car {PlateNumber}\nTotal amount: {Amount} EGP\nViolations:\n";

            
            foreach (var violation in Violations)
            {
                s += $"- {violation.Message}\n";
            }
            return s;

        }

    }
}

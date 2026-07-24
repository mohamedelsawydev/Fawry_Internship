using Fawry_Internship.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fawry_Internship.Models
{
    public class Violation
    {
        public Violation(string rule, string message, decimal cost)
        {
            Rule = rule;
            Message = message;
            Cost = cost;
        }

        public string Rule { get; set; }
        public string Message { get; set; }

        public decimal Cost { get; set; }




    }
}

using Fawry_Internship.Enums;
using Fawry_Internship.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fawry_Internship.Rules
{
    public interface IRule
    {
        public decimal  Cost { get; }
        Violation Validate(Observation observation);
    }
}

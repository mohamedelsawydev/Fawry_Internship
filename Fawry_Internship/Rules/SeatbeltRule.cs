using Fawry_Internship.Enums;
using Fawry_Internship.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fawry_Internship.Rules
{
    public class SeatbeltRule : IRule
    {
        public decimal Cost { get; } = 100;

        public Violation Validate(Observation observation)
        {

            if (observation.SeatbeltStatus==false)
            {
                return new Violation("SeatbeltRule", "Seatbelt not fastned  : "+ Cost +" EGP" ,Cost);
            }
            else
            {
                return null;
            }
        }
    }
}

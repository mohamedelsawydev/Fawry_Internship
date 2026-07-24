using Fawry_Internship.Enums;
using Fawry_Internship.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fawry_Internship.Rules
{
    public class PrivateSpeedRule : IRule
    {
        public decimal Cost { get; } = 300;
        private readonly int MaxSpeed  = 80;
        public Violation Validate(Observation observation)
        {
            if (observation.CarType != CarType.Private) { return null; }
            if (observation.Speed > MaxSpeed)
            {

                return new Violation("PrivateSpeedRule", "speed of " + observation.Speed + " exceeded max allowed " + MaxSpeed + " : " + Cost + " EGP", Cost);
            }
            else
            {
                return null;
            }
        }
    }
}

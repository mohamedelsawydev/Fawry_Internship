using Fawry_Internship.Enums;
using Fawry_Internship.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace Fawry_Internship.Models
{
    public  class RadarSystem
    {


        private readonly List<IRule> _rules = new();
        private readonly List<Fine> _fines = new();
        private readonly List<Violation> _violations = new();

        public void AddRule(IRule rule)
        {
            _rules.Add(rule);
        }
        public  void Check(Observation observation)
        {

            if (observation == null) { throw new ArgumentNullException("observation is null"); }

            decimal FineAmount = 0;
            var currentViolations = new List<Violation>();
            foreach (var rule in _rules)
            {
                    var violation = rule.Validate(observation);

                    if (violation != null)
                    {
                    currentViolations.Add(violation);
                        FineAmount += violation.Cost;


                    }
            }
            
            if (currentViolations.Count > 0)
            {
                _violations.AddRange(currentViolations);

                var fine = new Fine
                {
                    PlateNumber = observation.PlateNumber,
                    Amount = FineAmount,
                    Violations = currentViolations
                };
                _fines.Add(fine);

                Console.WriteLine(fine);
           
            }
           




        }

        public void  GetAllFines ()
        {
            foreach (var fine in _fines)
            {
                Console.WriteLine($"PlateNumber {fine.PlateNumber} : Amount {fine.Amount} EGY");
            }
        }

        public void GetAllViolatedRules()
        {
            var ruleCount = new Dictionary<string, int>();
            foreach (var violation in _violations)
            {
                var ruleName = violation.Rule;
                if (ruleCount.ContainsKey(ruleName))
                {
                    ruleCount[ruleName]++;
                }
                else
                {
                    ruleCount[ruleName] = 1;
                }
            }
            foreach (var kvp in ruleCount)
            {
                Console.WriteLine($"Rule: {kvp.Key}, Count: {kvp.Value}");
            }
        }




    }
}

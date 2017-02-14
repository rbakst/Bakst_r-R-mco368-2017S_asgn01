using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresidentialEligibilityCL
{
    public class PresidentialEligibility
    {
        private Boolean citizen;
        private int age;
        private int yearsResident;
        private int numPriorTerms;
        private Boolean impeached;
        private Boolean rebelled;
        public PresidentialEligibility(Boolean citizen, int birthYear, int yearsResident,
            int numPriorTerms, Boolean impeached, Boolean rebelled)
        {
            this.citizen = citizen;
            age = DateTime.Now.Year - birthYear;
            this.yearsResident = yearsResident;
            this.numPriorTerms = numPriorTerms;
            this.impeached = impeached;
            this.rebelled = rebelled;
        }

        public Boolean isEligible()
        {
            if (citizen == false || age < 35 || yearsResident < 14 || numPriorTerms > 1 || impeached == true || rebelled == true)
            {
                return false;
            }
            else return true;
        }
    }
}

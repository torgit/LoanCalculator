using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public enum PaybackPlanDescription { Monthly };

    public abstract class PaybackScheme
    {
        public PaybackPlanDescription planDescription { get; set; }

        public double totalInterest { get; set; }

        public double paybackPerUnit { get; set; }

        public abstract string generatePlan(LoanType loanType, double amount, double years);
    }
}

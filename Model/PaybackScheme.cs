using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{

    public abstract class PaybackScheme
    {
        public double totalInterest { get; set; }

        public double paybackPerUnit { get; set; }

        public abstract List<Result> generatePlan(LoanType loanType, double amount, double years);
    }
}

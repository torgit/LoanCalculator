using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class MonthlyPaybackScheme : PaybackScheme
    {
        public override string generatePlan(LoanType loanType, double amount, double years)
        {
            var numberOfPaymentInMonths = years * 12;
            var monthlyInterestRate = (loanType.InterestRate / 100) / 12;
            var onePlusMonthlyInterestRatePowered = Math.Pow(1 + Convert.ToDouble(monthlyInterestRate), numberOfPaymentInMonths);

            this.planDescription = PaybackPlanDescription.Monthly;
            this.paybackPerUnit = amount * (monthlyInterestRate * onePlusMonthlyInterestRatePowered) / (onePlusMonthlyInterestRatePowered - 1);
            this.totalInterest = paybackPerUnit * numberOfPaymentInMonths - amount;

            var result = String.Format("{0} payment = {1}\ntotal interest = {2}", planDescription, numericToPrintFormat(paybackPerUnit), numericToPrintFormat(totalInterest));
            return result;
        }

        private string numericToPrintFormat(double number)
        {
            return String.Format("{0:n}", number);
        }
    }
}

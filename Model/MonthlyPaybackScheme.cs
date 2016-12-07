using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class MonthlyPaybackScheme : PaybackScheme
    {
        public override List<Result> generatePlan(LoanType loanType, double amount, double years)
        {
            var resultList = new List<Result>();
            var numberOfPaymentInMonths = years * 12;
            var effectiveInterestRate = calculateEffectiveRate(loanType.InterestRate, 12);
            var monthlyInterestRate = (effectiveInterestRate / 100) / 12;

            this.paybackPerUnit = calculatePayment(amount, monthlyInterestRate, numberOfPaymentInMonths);
            this.totalInterest = paybackPerUnit * numberOfPaymentInMonths - amount;

            var currentPrincipal = amount;
            for(int i = 0; i < numberOfPaymentInMonths; i++)
            {
                var currentInterest = currentPrincipal * monthlyInterestRate;
                var newResult = new Result(currentPrincipal, paybackPerUnit, currentInterest, String.Format("Month {0}", i+1));
                resultList.Add(newResult);
                currentPrincipal += currentInterest;
                currentPrincipal -= paybackPerUnit;
            }

            return resultList;
        }

        private double calculateEffectiveRate(double statedRate, int compoundingPeriod)
        {
            return Math.Pow(1+statedRate/compoundingPeriod, compoundingPeriod)-1;
        }

        private double calculatePayment(double principal, double interestRate, double paymentPeriod)
        {
            return (principal * interestRate * Math.Pow(1 + interestRate, paymentPeriod)) / (Math.Pow(1 + interestRate, paymentPeriod)-1);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Result
    {
        public Result(double principal, double payment, double interest, string installment)
        {
            this.principal = roundTwoDigits(principal);
            this.payment = roundTwoDigits(payment);
            this.interest = roundTwoDigits(interest);
            this.installment = installment;
        }
        public string installment { get; }

        public double principal { get; }

        public double payment { get; }

        public double interest { get; }

        private double roundTwoDigits(double input)
        {
            return Math.Round(input, 2);
        }

    }
}

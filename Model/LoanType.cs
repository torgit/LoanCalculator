using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public enum LoanTypeDescription { Housing_loan, Car_loan }

    public class LoanType
    {
        public LoanType(LoanTypeDescription description, double interestRate) {
            this.Description = description;
            this.InterestRate = interestRate;
        }

        public LoanTypeDescription Description { get; set; }

        public double InterestRate { get; set; }

        public override string ToString()
        {
            return this.Description.ToString();
        }
    }
}

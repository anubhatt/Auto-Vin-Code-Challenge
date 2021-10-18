using System;
using System.Collections.Generic;
using System.Text;

namespace KARBankAssessment
{
    public sealed class IndividualInvestment : InvestmentAccount
    {
        private static string withdrawalLimitMessage = "More than 1000 dollars cannot be withdrawn from an Individual Checking account within a single transaction";

        public void Withdrawal(int amount)
        {
            if(amount > 1000)
            {
                throw new ArgumentOutOfRangeException(withdrawalLimitMessage);
            }
            balance = balance - amount;
        }

        public void Deposit(int amount)
        {
            balance = balance + amount;
        }

        public void Transfer(int amount, bool isRecipient)
        {
            if (isRecipient)
            {
                balance = balance + amount;
            }
            else
            {
                balance = balance - amount;
            }
        }
    }
}

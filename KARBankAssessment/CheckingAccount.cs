using System;
using System.Collections.Generic;
using System.Text;

namespace KARBankAssessment
{
    public sealed class CheckingAccount : Account , ITransaction
    {
        public void Withdrawal(int amount)
        {
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

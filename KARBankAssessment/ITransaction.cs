using System;
using System.Collections.Generic;
using System.Text;

namespace KARBankAssessment
{
    interface ITransaction
    {
        void Withdrawal(int amount);
        void Deposit(int amount);
        void Transfer(int amount, bool isRecipient);
    }
}

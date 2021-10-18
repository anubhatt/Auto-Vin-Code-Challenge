using Microsoft.VisualStudio.TestTools.UnitTesting;
using KARBankAssessment;

namespace KARBankUnitTests
{
    [TestClass]
    public class CheckingAccountUnitTests
    {
        [TestMethod]
        public void Deposit_Into_Checking_Account_Happy_Path()
        {
            //Arrange
            CheckingAccount testAccount = new CheckingAccount();
            testAccount.balance = 100;
            testAccount.owner = "test owner";
            double expectedBalance = 110;

            //Act
            testAccount.Deposit(10);

            //Assert
            Assert.AreEqual(expectedBalance, testAccount.balance);
        }

        [TestMethod]
        public void Withdrawal_From_Checking_Account_Happy_Path()
        {
            //Arrange
            CheckingAccount testAccount = new CheckingAccount();
            testAccount.balance = 100;
            testAccount.owner = "test owner";
            double expectedBalance = 90;

            //Act
            testAccount.Withdrawal(10);

            //Assert
            Assert.AreEqual(expectedBalance, testAccount.balance);
        }

        [TestMethod]
        public void Transfer_Out_Of_Checking_Account_Happy_Path()
        {
            //Arrange
            CheckingAccount testAccount = new CheckingAccount();
            testAccount.balance = 100;
            testAccount.owner = "test owner";
            double expectedBalance = 90;

            //Act
            testAccount.Transfer(10, false);

            //Assert
            Assert.AreEqual(expectedBalance, testAccount.balance);
        }

        [TestMethod]
        public void Transfer_into_Checking_Account_Happy_Path()
        {
            //Arrange
            CheckingAccount testAccount = new CheckingAccount();
            testAccount.balance = 100;
            testAccount.owner = "test owner";
            double expectedBalance = 110;

            //Act
            testAccount.Transfer(10, true);

            //Assert
            Assert.AreEqual(expectedBalance, testAccount.balance);
        }
    }
}

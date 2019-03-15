using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankAccountNS;

namespace BankTests
{
    [TestClass]
    public class BankAccountTests
    {
        [TestMethod]
        public void Debit_WithValidAmount_UpdatesBalance()
        {
            //Arrange
            double beginningBalance = 11.99;
            double debitAmount = 4.55;
            double expected = 7.44;
            BankAccount account = new BankAccount("Mr. Arun Bhatia", beginningBalance);

            //Act
            account.Debit(debitAmount);

            //Assert
            double actual = account.Balance;
            Assert.AreEqual(expected, actual, 0.0001, "Account not debited correctly");
        }

        [TestMethod]
        
        public void Debit_WhenAmountIsLessThanZero_ShouldThrowArgumentOutOfRange()
        {
            double beginningbalance = 11.99;
            double debitAmount = 20.00;
            BankAccount account = new BankAccount("Mr. Arun bhatia1", beginningbalance);

            //act
            try
            {
                account.Debit(debitAmount);
            }
            catch(ArgumentOutOfRangeException e)
            {
                StringAssert.Contains(e.Message, BankAccount.DebitAEBM);
            }

            //
        }
    }
}

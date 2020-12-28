using Bank.Entities.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bank.Test.Entities
{
    [TestClass]
    public class BankAccountTest
    {
        private Mock<IBankAccount> _mock;
        [TestMethod]
        public void BankAccount_AddInterest_BalancePlusInterest_Test()
        {
            BankAccount account = new BankAccount();
            _mock = new Mock<IBankAccount>();

            BankAccount accountMock = new BankAccount();
            accountMock.SetNameOfCustomer("Josefano");
            accountMock.Balance = 130.00;

            _mock.Setup(x => x.AddInterest(It.IsAny<double>()));
            double balanceRes = 130.00;
            double balanceUpdated = account.AddInterest(130.00);
            Assert.AreEqual(balanceRes, balanceUpdated);
        }
    }
}

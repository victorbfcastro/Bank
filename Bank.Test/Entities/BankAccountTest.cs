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
        [TestMethod]//================================== INTEREST ==================================

        public void BankAccount_AddInterest_BalancePlusInterest_Test()
        {
            BankAccount account = new BankAccount();
           
            account.SetNameOfCustomer("Josefano");
            account.Balance = 130.00;

            double interest = 0.5;
            double esperado = account.Balance * interest;
            double balanceUpdated = account.AddInterest(interest);

            Assert.AreEqual(65, balanceUpdated);
        }
        
        [TestMethod]//================================== CREDITO SUCCESS ==================================
        public void BankAccount_Credito_BalancePlusCredit_Test_Success()
        {
            BankAccount account = new BankAccount();

            account.SetNameOfCustomer("Josefano");
            account.Balance = 130.00;

            double credito = 150.00;
            double esperado = account.Balance + credito;
            double balanceUpdated = account.Credito(credito);

            Assert.AreEqual(280, balanceUpdated);
        }

        [TestMethod]//================================== CREDITO EXCEPTION ==================================
        [ExpectedException(typeof(Exception))]

        public void BankAccount_Credito_BalancePlusCredit_Test_Exception()
        {
            BankAccount account = new BankAccount();

            account.SetNameOfCustomer("Josefano");
            account.Balance = 130.00;

            double amount = -1;
            double esperado = account.Balance + amount;
            double balanceUpdated = account.Credito(amount);


        }

        [TestMethod]//================================== DEBITO SUCCESS ==================================
        public void BankAccount_Debito_BalancePlusDebit_Test_Success()
        {
            BankAccount account = new BankAccount();

            account.SetNameOfCustomer("Josefano");
            account.Balance = 130.00;

            double amount = 30.00;
            double esperado = account.Balance - (amount * 1.025);
            double balanceUpdated = account.Debito(amount);

            Assert.AreEqual(esperado, balanceUpdated);
        }

        [TestMethod]//================================== DEBITO EXCEPTION BALANCE ==================================
        [ExpectedException(typeof(Exception))]
        public void BankAccount_Debito_BalancePlusDebit_Test_ExceptionBalance()
        {
            BankAccount account = new BankAccount();

            account.SetNameOfCustomer("Josefano");
            account.Balance = 130.00;

            double amount = 150.00;
            double esperado = account.Balance - (amount * 1.025);
            double balanceUpdated = account.Debito(amount);

        }

        [TestMethod]//================================== DEBITO EXCEPTION NEGATIVO ==================================
        [ExpectedException(typeof(Exception))]
        public void BankAccount_Debito_BalancePlusDebit_Test_ExceptionNegativo()
        {
            BankAccount account = new BankAccount();

            account.SetNameOfCustomer("Josefano");
            account.Balance = -12;

            double amount = 150.00;
            double esperado = account.Balance - (amount * 1.025);
            double balanceUpdated = account.Debito(amount);

        }

    }
}

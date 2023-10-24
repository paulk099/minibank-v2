﻿using MiniBankApp2.Enums;
using MiniBankApp2.Models;
using Transaction = MiniBankApp2.Models.Transaction; // Apply an Alias for our preffered transaction type to avoid conflict with a built in type of the same name

namespace MiniBankApp2.Interfaces
{
    internal interface IBankAccount
    {

        // Properties expected of all bank accounts
        public string AccountName { get; }
        public int AccountNumber { get; }
        public string AccountType { get; }
        public string Bank { get; }

        public List<Transaction> Transactions { get; }
        public List<Beneficiary> Beneficiaries { get; }

        // Methods/Behaviours expected of all bank accounts
        public void Deposit(double amount);

        public void Withdraw(double amount);

        public void DisplayBalance();

        public void PrintHistory();
    }
}




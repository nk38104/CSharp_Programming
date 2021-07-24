using System;
using System.Collections.Generic;
using System.Text;

namespace task03
{
    enum AccountType
    {
        Savings,
        Gyro,
        Current
    }
    class BankAccount
    {
        public int Id { get; set; }
        public double Balance { get; set; }
        public AccountType Type { get; set; }

        public BankAccount(int  id, double balance, AccountType type)
        {
            Id = id;
            Balance = balance;
            Type = type;
        }
    }
}

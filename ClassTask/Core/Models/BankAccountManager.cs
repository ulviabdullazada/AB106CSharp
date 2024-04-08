using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public static class BankAccountManager
    {
        static BankAccount[] bankAccounts = new BankAccount[0];

        public static void CreateAccount(BankAccount bankAccount)
        {
            Array.Resize(ref bankAccounts, bankAccounts.Length+1);
            bankAccounts[bankAccounts.Length-1] = bankAccount;
        }

        public static BankAccount FindAccount(string name)
        {
            
            foreach (BankAccount account in bankAccounts)
            {
                if (account.CustomeName == name)
                {
                    return account;

                }

            }
            return null;

        }


        public static void Deposit(string customerName , double amount)
        {
            BankAccount acc = FindAccount(customerName);

            if (acc != null)
            {
                acc.Balance += amount;
            }
            else
            {
                Console.WriteLine("bele istifadeci yoxdur");
            }


        }



        public static void Withdraw(string customerName, double amount)
        {
            BankAccount acc = FindAccount(customerName);

            if (acc != null)
            {
                if (acc.Balance > amount)
                {
                    acc.Balance -= amount;
                }
                else
                {
                    Console.WriteLine("kasib");
                }
            }
            else
            {
                Console.WriteLine("bele istifadeci yoxdur");
            }
        }

        public static void GetBalance(string customerName)
        {
            BankAccount acc = FindAccount(customerName);

            Console.WriteLine(acc.CustomeName);

        }


    }
}

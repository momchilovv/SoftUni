using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<int, BankAccount> bankInfo = new Dictionary<int, BankAccount>();

        var input = Console.ReadLine();       

        while (input != "End")
        {
            var command = input.Split();
            switch (command[0])
            {
                case "Create":
                    Create(int.Parse(command[1]), bankInfo);
                    break;
                case "Deposit":
                    Deposit(int.Parse(command[1]), decimal.Parse(command[2]), bankInfo);
                    break;
                case "Withdraw":
                    Withdraw(int.Parse(command[1]), decimal.Parse(command[2]), bankInfo);
                    break;
                case "Print":
                    Print(int.Parse(command[1]), bankInfo);
                    break;
            }
            input = Console.ReadLine();
        }
    }
    static void Create(int id, Dictionary<int, BankAccount> bankInfo)
    {
        if (bankInfo.ContainsKey(id))
        {
            Console.WriteLine("Account already exists");
        }
        else
        {
            BankAccount account = new BankAccount();
            account.Id = id;
            bankInfo.Add(id, account);
        }
    }
    static void Deposit(int id, decimal ammount, Dictionary<int, BankAccount> bankInfo)
    {
        if (!bankInfo.ContainsKey(id))
        {
            Console.WriteLine("Account does not exist");
            return;
        }
        else
        {
            bankInfo[id].Deposit(ammount);
        }
    }
    static void Withdraw(int id, decimal ammount, Dictionary<int, BankAccount> bankInfo)
    {
        if (!bankInfo.ContainsKey(id))
        {
            Console.WriteLine("Account does not exist");
            return;
        }
        if (bankInfo[id].Balance < ammount)
        {
            Console.WriteLine("Insufficient balance");
            return;
        }
        bankInfo[id].Withdraw(ammount);
    }
    static void Print(int id, Dictionary<int, BankAccount> bankInfo)
    {
        if (!bankInfo.ContainsKey(id))
        {
            Console.WriteLine("Account does not exist");
            return;
        }
        Console.WriteLine(bankInfo[id].ToString());
    }
}
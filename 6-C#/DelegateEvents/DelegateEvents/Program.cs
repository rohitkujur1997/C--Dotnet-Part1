﻿using System;


namespace DelegateEvents
{
    class BankAtm
    {

        public delegate void delegatemethod(int x);

        public class Account
        {
            public int AccountNumber { get; set; }
            public int CustomerName { get; set; }


            public int Balance = 1000;

            public event delegatemethod UnderBalance;
            public event delegatemethod ZeroBalance;


            public void Insufficient(int x)
            {
                UnderBalance(x);

            }
            public void DepositMoney(int y)
            {
                ZeroBalance(y);

            }

            public void WithDraw(int x)
            {
                if (x < Balance && Balance != 0)
                {
                    Console.WriteLine("Transaction Succesfull");
                    Console.WriteLine("Remaining Balance is " + (Balance - x));
                }
                else if (x > Balance && Balance != 0)
                {
                    Console.WriteLine("Insufficient Amount");
                    Console.WriteLine("Your Current Balance is " + Balance + " only");
                }
                else
                {
                    Console.WriteLine("Zero Balance :" + Balance);
                }
            }

            public void Deposit(int x)
            {
                Console.Write("Balance After Depositing: " + (Balance + x));
            }
        }

        static void Main(string[] args)
        {
            Account obj = new Account();
            Console.WriteLine("Action to be performed WithDraw Amount or Deposit : w or d");
            string wd = Console.ReadLine();
            if (wd == "w")
            {
                Console.WriteLine("Enter Balance to be WithDrawn");
                int wdbalance = Convert.ToInt32(Console.ReadLine());
                obj.UnderBalance += new delegatemethod(obj.WithDraw);
                obj.Insufficient(wdbalance);
            }
            else
            {
                Console.WriteLine("Enter Amount to be Deposit : ");
                int dpbalance = Convert.ToInt32(Console.ReadLine());
                obj.ZeroBalance += new delegatemethod(obj.Deposit);
                obj.DepositMoney(dpbalance);
            }
            Console.ReadKey();
        }
    }
}
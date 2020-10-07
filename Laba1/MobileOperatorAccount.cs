using System;
using System.Collections.Generic;

namespace Laba1
{
    class MobileOperatorAccount
    {
        private double costPerMinute;
        private double accountAmount;
        private long phoneNumber;

        private List<string> callHistory = new List<string>();

        public MobileOperatorAccount()
        {
        }

        public MobileOperatorAccount(double accountAmount, long phoneNumber)
        {
            this.accountAmount = accountAmount;
            this.phoneNumber = phoneNumber;
        }

        public void tariffСhange(string tariff)
        {
            while (true)
            {
                try
                {
                    Tariff tarifff = (Tariff) Enum.Parse(typeof(Tariff), tariff!, true);
                    switch (tarifff)
                    {
                        case Tariff.Supernetstart:
                            accountAmount = accountAmount - 20;
                            costPerMinute = 0.5;
                            Console.WriteLine("Tariff SuperNet Start connected, every minute cost " + costPerMinute +
                                              " , your account amount = " +
                                              accountAmount);
                            break;
                        case Tariff.Supernetpro:
                            accountAmount = accountAmount - 30;
                            costPerMinute = 0.4;
                            Console.WriteLine("Tariff SuperNet Pro connected, every minute cost " + costPerMinute +
                                              " , your account amount = " +
                                              accountAmount);
                            break;
                        case Tariff.Supernetunlim:
                            accountAmount = accountAmount - 40;
                            costPerMinute = 0.3;
                            Console.WriteLine("Tariff SuperNet Unlim connected, every minute cost " + costPerMinute +
                                              " , your account amount = " +
                                              accountAmount);
                            break;
                        default:
                            Console.WriteLine("There is no tariff like that...Try again");
                            break;
                    }
                    break;
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Try again...");
                    tariff = Console.ReadLine();
                    
                }
            }
        }

        public double phoneCall(double numberOfMinutes, long phoneNumber)
        {
            accountAmount = accountAmount - (numberOfMinutes * costPerMinute);
            callHistory.Add("You called this number: " + phoneNumber + " and speaking " + numberOfMinutes +
                            " minutes.");
            return numberOfMinutes * costPerMinute;
        }

        public void refillAndShowAccountAmount(double moneyAmount)
        {
            accountAmount = accountAmount + moneyAmount;
            Console.WriteLine("Amount of money in the account: " + accountAmount);
        }

        public void showCallHistory()
        {
            foreach (string history in callHistory)
            {
                Console.WriteLine(history);
            }
        }

        public double getCostPerMinute => costPerMinute;
        public double getAccountAmount => accountAmount;
    }

    enum Tariff
    {
        Supernetstart,
        Supernetpro,
        Supernetunlim
    }
}
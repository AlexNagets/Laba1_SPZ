using System;

namespace Laba1
{
    public class Application
    {

        public static void Main(string[] args)
        {
            
            Console.WriteLine("Write your phone number(10 numbers): ");
            string yourPhoneNumber = Console.ReadLine();
            long yourValidatedPhoneNumber = Validator.validatePhoneNumber(yourPhoneNumber);

            Console.WriteLine("Refill your account to: ");
            string accountAmount = Console.ReadLine();
            double validatePositiveAmount = Validator.validatePositiveAmount(accountAmount);

            MobileOperatorAccount mobileOperatorAccount = 
                new MobileOperatorAccount(validatePositiveAmount, yourValidatedPhoneNumber);

            Console.WriteLine("Choose your tariff (Supernetstart(-20),Supernetpro(-30),Supernetunlim(-40)): ");
            string tariff = Console.ReadLine();
            mobileOperatorAccount.tariffСhange(tariff);

            Console.WriteLine("Call your friend :) \nEnter the phone number: ");
            string desiredPhoneNumber = Console.ReadLine();
            long validatedDesiredPhoneNumber = Validator.validatePhoneNumber(desiredPhoneNumber);

            Console.WriteLine("Enter amount of minutes: ");
            string amountOfMinutes = Console.ReadLine();
            double positiveAmountOfMinutes = Validator.validatePositiveAmount(amountOfMinutes);
            double validatedEnoughAndPositiveMoneyOnAccount = Validator.validateEnoughMoneyOnAccount(positiveAmountOfMinutes.ToString(), mobileOperatorAccount.getCostPerMinute, mobileOperatorAccount.getAccountAmount);
            
            Console.WriteLine("You spend: " +  mobileOperatorAccount.phoneCall(validatedEnoughAndPositiveMoneyOnAccount,validatedDesiredPhoneNumber) + " money for call");

            Console.WriteLine("Enter the amount you want to refill your account: ");
            string refill = Console.ReadLine();
            double validatedRefill = Validator.validatePositiveAmount(refill);
            mobileOperatorAccount.refillAndShowAccountAmount(validatedRefill);
            
            Console.WriteLine("Your call history: ");
            mobileOperatorAccount.showCallHistory();
        }
    }
}
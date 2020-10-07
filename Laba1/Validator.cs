using System;

namespace Laba1
{
    public class Validator
    {
        public static long validatePhoneNumber(string phoneNumber)
        {
            while (phoneNumber != null && phoneNumber.Length != 10)
            {
                Console.WriteLine("Invalid phone number, please try again (enter 10 numbers)");
                phoneNumber = Console.ReadLine();
            }

            return Convert.ToInt64(phoneNumber);
        }

        public static double validatePositiveAmount(string probablyNegativeAmount)
        {
            while (Convert.ToDouble(probablyNegativeAmount) <= 0)
            {
                Console.WriteLine("Enter a positive amount: ");
                probablyNegativeAmount = Console.ReadLine();
            }
            return Convert.ToDouble(probablyNegativeAmount);
        }

        public static double validateEnoughMoneyOnAccount(string numberOfMinutes, double costPerMinute,
            double accountAmount)
        {
            while (!(accountAmount >= (Convert.ToDouble(numberOfMinutes) * costPerMinute)))
            {
                Console.WriteLine("Not enough money... Enter another amount of minutes");
                numberOfMinutes = Console.ReadLine();
            }
            return Convert.ToDouble(numberOfMinutes);
        }
    }
}
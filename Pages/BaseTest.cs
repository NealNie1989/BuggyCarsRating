using System;
using System.Collections.Generic;
using System.Text;

namespace BuggyCarsRating.Pages
{
    public static class BaseTest
    {
        public static string randomString(int length)
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[length];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            var finalString = new String(stringChars);

            return finalString;
        }

        public static string getUserName()
        {
            return randomString(6);
        }

        public static string userName = getUserName();

        public static string getFirstName()
        {
            return randomString(4);
        }

        public static string getLastName()
        {
            return randomString(4);
        }

        public static string getPassword()
        {
            return "Qq12345@";
        }

        public static string getFatalPassword()
        {
            return "Qq12345";
        }

        public static string getComments = randomString(10);
    }
}

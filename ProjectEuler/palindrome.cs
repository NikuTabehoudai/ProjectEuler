using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler
{
    class palindrome
    {
        public palindrome()
        {

            int a = 999;
            int b = 999;
            int palindrome = 0;

            for (int i = 0; i < a; i++)
            {
                for (int ii = 0; ii < b; ii++)
                {
                    var ab = i * ii;
                    if (IsPalindrome(ab))
                    {
                        if (ab > palindrome)
                        palindrome = ab;
                    }
                }
            }

            Console.WriteLine("Palindrome");
            Console.WriteLine(palindrome);
        }


        public bool IsPalindrome(int input)
        {

            var reverse = input.ToString().ToCharArray();
            Array.Reverse(reverse);
            string test = new string(reverse);
            bool paldindrome = false;

            if (input.ToString() == test)
            {
                paldindrome = true;
            }

            return paldindrome;
        }

    }
}

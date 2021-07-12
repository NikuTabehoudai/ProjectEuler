using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler
{
    class SumPrimes
    {

        public SumPrimes()
        {
            int target = 2000000;
            long output = 0;


            for (int i = 0; i < target; i+=2)
            {
                if (isPrime(i))
                    output += i;

                if (i == 2)
                    i--;
            }

            Console.WriteLine(output);

        }

        public static bool isPrime(int number)
        {
            if (number == 0) return false;
            if (number == 1) return false;
            if (number == 2 || number == 3) return true;
            if (number % 2 == 0) return false;

            for (int n = 3; n < number; n += 2)
            {
                if (number % n == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }

}

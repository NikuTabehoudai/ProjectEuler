using System;
using System.Collections.Generic;

namespace ProjectEuler
{
    class PrimeFactor
    {
        public PrimeFactor()
        {
            List<int> factor = new List<int>();
            long input = 600851475143;
            int prime = 2;

            Console.WriteLine("Prime Factors");
            while (input != 1)
            {

                if (input % prime == 0)
                {
                    input = input / prime;
                    factor.Add(prime);
                }
                prime = NextPrime(prime);

            }

            foreach (var item in factor)
            {
                Console.WriteLine(item);
            }


        }


        public int NextPrime(int input)
        {
            input++;  
            

            while (!isPrime(input))
            {
                input++;
            }

           return input;
        }


        public static bool isPrime(int number)
        {
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

using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler
{
    class XPrime
    {

        public XPrime()
        {

            var goal = 10001;
            var i = 0;
            var prime = 1;
            var output = 0;

            while (i < goal)
            {
                if (prime == 2) i++;

                if (!(prime % 2 == 0))
                {
                    if (isPrime(prime))
                    {
                        i++;
                        output = prime;
                    }
                }

                prime++;
            }

            Console.WriteLine("Prime number " + goal.ToString() +":") ;
            Console.WriteLine(output);

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

using System;
using System.Collections.Generic;

namespace ProjectEuler
{
    class Fibonacci
    {
        
        public Fibonacci()
        {
            int output = 0;
            List<int> i = new List<int>() { 1, 1, 0 };

            while (i[0] !<= 4000000)
            {

                i[2] = i[0] + i[1];
                i[0] = i[1];
                i[1] = i[2];

                if (i[2] % 2 == 0)
                {
                    output = output + i[2];
                }

            }

            Console.WriteLine("Fibonacci");
            Console.WriteLine(output);

        }



    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler
{
    class SmallestMultiple
    {

        public SmallestMultiple()
        {
        int i = 1;
            while (!Divisible(i))
            {
                i++;
            }
            Console.WriteLine("Smallest Multiple");
            Console.WriteLine(i);
        }

        public bool Divisible(int input)
        {
            int target = 20;
            for (int i = 1; i < target; i++)
            {
                if (input % i != 0)
                {
                    return false;
                }
            }
            return true;
        }



    }
}

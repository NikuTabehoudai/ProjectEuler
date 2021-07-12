using System;

namespace ProjectEuler
{
    class Multiples
    {

        public Multiples()
        {
            int output = 0;

            for (int i = 0; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    output = output + i;
                }
            }
            Console.WriteLine("Multiples");
            Console.WriteLine(output);
        }

    }
}

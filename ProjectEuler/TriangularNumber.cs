using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler
{
    class TriangularNumber
    {

        public TriangularNumber()
        {
            int startNum = 0;
            int count = 1;
            long num = 0;
            long limit = 0;
            long divisor = 1;


            for (int i = 0; count < 500; i++)
            {
                count = 1;
                divisor = 1;
                num += i;

                if (num <= startNum) continue;

                if (num % 2 == 0)
                    limit = num / 2;
                else
                    limit = num / 3;

                while (divisor <= limit)
                {
                    if (num % divisor == 0) count++;
                    divisor++;
                }
            }

            Console.WriteLine(num);
        }
    }
}

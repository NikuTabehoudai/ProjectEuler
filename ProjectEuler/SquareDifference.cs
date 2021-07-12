using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler
{
    class SquareDifference
    {

        public SquareDifference()
        {

            int t1 = 0;
            int t2 = 0;
            int si = 100;


            for (int i = 0; i <= si; i++)
            {
                t1 = t1 + (i * i);
                t2 = t2 + i;
            }

            t2 = t2 * t2;

            Console.WriteLine(t2 - t1);

        }




    }
}

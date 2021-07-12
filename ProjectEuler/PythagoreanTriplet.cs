using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler
{
    class PythagoreanTriplet
    {


        public PythagoreanTriplet()
        {

            int target = 1000;

            for (int a = 1; a < target; a++)
            {
                for (int b = a + 1; b < target; b++)
                {
                    var c = target - a - b;

                    if (a*a + b*b == c*c)
                    {
                        Console.WriteLine(a * b * c);
                        break;
                    }

                }
            }
        }
    }
}


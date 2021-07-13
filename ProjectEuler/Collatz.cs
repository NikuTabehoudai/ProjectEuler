using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler
{
    class Collatz
    {


        public Collatz()
        { 
        int targetNumber = 1000000;
        int currentNumber = 1;
        var output = new List<int>() { 0, 0 };


            while (currentNumber <= targetNumber)
            {
                long number = currentNumber;
                var counter = 1;
                while (number != 1)
                {
                    if (number % 2 == 0)
                        number = number / 2;
                    else
                        number = number * 3 +1;
                    counter++;
                }

                if (output[1] < counter)
                {
                    output[0] = currentNumber;
                    output[1] = counter;

                    Console.WriteLine(output[0].ToString() + "/" + output[1].ToString());
                }
                currentNumber++;

            }
            Console.WriteLine(output[0]);
        }
    }
}

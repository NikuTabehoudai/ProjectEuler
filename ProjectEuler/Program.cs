using System;

namespace ProjectEuler
{
    class Program
    {
        static void Main(string[] args)
        {
            string cases = "11";
            string input = "";
            object project;

            while (input.ToLower() != "end")
            {
                Console.WriteLine("Chose Project Euler case, Currently avaiable up to case: (" + cases + ")");
                input = Console.ReadLine();

                switch (input)
                {
                case "1":
                    project = new Multiples();
                    break;
                case "2":
                    project = new Fibonacci();
                    break;
                case "3":
                    project = new PrimeFactor();
                    break;
                case "4":
                     project = new palindrome();
                    break;
                case "5":
                    project = new SmallestMultiple();
                    break;
                case "6":
                    project = new SquareDifference();
                    break;
                case "7":
                    project = new XPrime();
                    break;
                case "8":
                    project = new LargestProduct();
                    break;
                case "9":
                    project = new PythagoreanTriplet();
                    break;
                case "10":
                        // is slow, like super slow, like 5 min slow. Needs rework if i can be arsed.
                    project = new SumPrimes();
                    break;
                case "11":
                    project = new LargestProductInGrid();
                break;
                case "12":
                    project = new TriangularNumber();
                break;


                }
            }

        }
    }
}

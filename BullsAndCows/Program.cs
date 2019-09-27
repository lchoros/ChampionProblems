using System;

namespace BullsAndCows
{
    class Program
    {
        static void Main(string[] args)
        {
            int secret = int.Parse(Console.ReadLine());
            int bulls = int.Parse(Console.ReadLine());
            int cows = int.Parse(Console.ReadLine());
            bool solutionFound = false;
            int firstSecretDigit = secret / 1000 % 10;
            int secondSecretDigit = secret / 100 % 10;
            int thirdSecretDigit = secret / 10 % 10;
            int fourthSecretDigit = secret / 1 % 10;


            for (int i = 1000; i < 10000 ; i++)
            {
                int b = 0;
                int c = 0;

                int firstGuessDigit = firstSecretDigit;
                int secondGuessDigit = secondSecretDigit;
                int thirdGuessDigit = thirdSecretDigit;
                int fourthGuessDigit = fourthSecretDigit;

                int firstDigit = i / 1000 % 10;
                int secondDigit  = i / 100 % 10;
                int thirdDigit = i/ 10 % 10;
                int fourthDigit  = i % 10;
                if(firstDigit == 0 || secondDigit == 0 || thirdDigit == 0 || fourthDigit == 0)
                {
                    continue;
                }
                if (firstDigit == firstGuessDigit)
                {
                    firstDigit = -1;
                    firstGuessDigit = -2;
                    b++;
                }
                if (secondDigit == secondGuessDigit)
                {
                    secondDigit = -1;
                    secondGuessDigit = -2;
                    b++;
                }
                if (thirdDigit == thirdGuessDigit)
                {
                    thirdDigit = -1;
                    thirdGuessDigit = -2;
                    b++;
                }
                if (fourthDigit == fourthGuessDigit)
                {

                    fourthDigit = -1;
                    fourthGuessDigit = -2;
                    b++;
                }

                if (firstDigit == secondGuessDigit)
                {
                    secondGuessDigit = -2;
                    c++;
                }
                else if (firstDigit == thirdGuessDigit)
                {
                    thirdGuessDigit = -2;
                    c++;
                }
                else if (firstDigit == fourthGuessDigit)
                {
                    fourthGuessDigit = -2;
                    c++;
                }

                if (secondDigit == firstGuessDigit)
                {
                    firstGuessDigit = -2;
                    c++;
                }
                else if (secondDigit == thirdGuessDigit)
                {
                    thirdGuessDigit = -2;
                    c++;
                }
                else if (secondDigit == fourthGuessDigit)
                {
                    fourthGuessDigit = -2;
                    c++;
                }

                if (thirdDigit == firstGuessDigit)
                {
                    secondGuessDigit = -2;
                    c++;
                }
                else if (thirdDigit == secondGuessDigit)
                {
                    thirdGuessDigit = -2;
                    c++;
                }
                else if (thirdDigit == fourthGuessDigit)
                {
                    fourthGuessDigit = -2;
                    c++;
                }

                if (fourthDigit == firstGuessDigit)
                {
                    secondGuessDigit = -2;
                    c++;
                }
                else if (fourthDigit == secondGuessDigit)
                {
                    thirdGuessDigit = -2;
                    c++;
                }
                else if (fourthDigit == thirdGuessDigit)
                {
                    fourthGuessDigit = -2;
                    c++;
                }


                if (b == bulls && c == cows)
                {
                    solutionFound = true;
                    Console.Write("{0}{1}{2}{3} ", i / 1000 % 10, i / 100 % 10, i/ 10 % 10,i % 10);
                }
            }

            if(!solutionFound)
            {
                Console.WriteLine("No");
            }
        }
    }
}



//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace BullsAndCows
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int secret = int.Parse(Console.ReadLine());
//            int bulls = int.Parse(Console.ReadLine());
//            int cows = int.Parse(Console.ReadLine());


//            int firstSecretDigit = secret / 1000 % 10;
//            int secondSecretDigit = secret / 100 % 10;
//            int thirdSecretDigit = secret / 10 % 10;
//            int fourthSecretDigit = secret / 1 % 10;
//            bool solutionFound = false;


//            for (int d1 = 1; d1 <= 9; d1++)
//            {
//                for (int d2 = 0; d2 <= 9; d2++)
//                {
//                    for (int d3 = 0; d3 <= 9; d3++)
//                    {
//                        for (int d4 = 0; d4 <= 9; d4++)
//                        {

//                            int digitToCheck1 = d1;
//                            int digitToCheck2 = d2;
//                            int digitToCheck3 = d3;
//                            int digitToCheck4 = d4;

//                            int bullCounter = 0;
//                            int cowCounter = 0;
//                            if (digitToCheck1 == firstSecretDigit)
//                            {
//                                firstSecretDigit = -1;
//                                digitToCheck1 = -2;
//                                bullCounter++;

//                            }
//                            if (digitToCheck2 == secondSecretDigit)
//                            {
//                                secondSecretDigit = -1;
//                                digitToCheck2 = -2;
//                                bullCounter++;
//                            }
//                            if (digitToCheck3 == thirdSecretDigit)
//                            {
//                                secondSecretDigit = -1;
//                                digitToCheck2 = -2;
//                                bullCounter++;
//                            }
//                            if (digitToCheck2 == secondSecretDigit)
//                            {
//                                secondSecretDigit = -1;
//                                digitToCheck2 = -2;
//                                bullCounter++;
//                            }
//                            if (bulls == bullCounter && cowCounter == cows)
//                            {
//                                Console.WriteLine("{0}{1}{2}{3}", d1, d2, d3, d4);
//                            }
//                        }
//                    }
//                }
//            }
//            if (!solutionFound)
//            {
//                Console.WriteLine("No");
//            }
//        }
//    }
//}

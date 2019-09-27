using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            //for (int l1 = 1; l1 <= 5; l1++)
            //{
            //    for (int l2 = 2; l2 <= 5; l2++)
            //    {
            //        for (int l3 = 3; l3 <= 5; l3++)
            //        {
            //            for (int l4 = 4; l4 <= 5; l4++)
            //            {
            //                for (int l5 = 5; l5 <= 5; l5++)
            //                {
            //                    //if(l2 != l1)
            //                    //{
            //                    //    wordWeight += l2.ToString();
            //                    //}
            //                    //if(l3 != l1 && l3 != l2)
            //                    //{

            //                    //}
            //                    //if(l4 != l1 && l4 != l2 && l4 != l3)
            //                    //{

            //                    //}
            //                    Console.WriteLine("{0}{1}{2}{3}{4}", l1, l2, l3, l4, l5);
            //                }
            //            }
            //        }
            //    }
            //}


            for (char l1 = 'a'; l1 <= 'e'; l1++)
            {
                for (char l2 = 'a'; l2 <= 'e'; l2++)
                {
                    for (char l3 = 'a'; l3 <= 'e'; l3++)
                    {
                        for (char l4 = 'a'; l4 <= 'e'; l4++)
                        {
                            for (char l5 = 'a'; l5 <= 'e'; l5++)
                            {
                                int weight = 0;
                                string samp = string.Empty;
                                samp += l1;
                                int multiplier = 1;
                                if (l2 != l1)
                                {
                                    samp += l2;
                                }
                                if (l3 != l1 && l3 != l2)
                                {
                                    samp += l3;

                                }
                                if (l4 != l1 && l4 != l2 && l4 != l3)
                                {
                                    samp += l4;

                                }
                                if (l5 != l1 && l5 != l2 && l5 != l3 && l5 != l4)
                                {
                                    samp += l5;
                                }
                                for (int i = 0; i < samp.Length; i++)
                                {
                                    if(samp[i] == 'a')
                                    {
                                        weight += multiplier * 5;
                                    }
                                    else if (samp[i] == 'b')
                                    {
                                        weight += multiplier * -12;
                                    }
                                    else if (samp[i] == 'c')
                                    {
                                        weight += multiplier * 47;
                                    }
                                    else if (samp[i] == 'd')
                                    {
                                        weight += multiplier * 7;
                                    }
                                    else if (samp[i] == 'e')
                                    {
                                        weight += multiplier * -32;
                                    }
                                    multiplier++;
                                }
                                if(weight >= start && weight <= end)
                                {
                                    Console.WriteLine("{0}{1}{2}{3}{4}", l1, l2, l3, l4, l5);
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}

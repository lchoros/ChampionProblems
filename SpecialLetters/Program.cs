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
                                string wordWeight = l1.ToString();

                                if(l2 != l1)
                                {
                                    wordWeight += l2.ToString();
                                }
                                if(l3 != l1 && l3 != l2)
                                {

                                }
                                if(l4 != l1 && l4 != l2 && l4 != l3)
                                {

                                }
                                Console.WriteLine("{0}{1}{2}{3}{4}", l1, l2, l3, l4, l5);
                            }
                        }
                    }
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDates
{
    class Program
    {
        static void Main(string[] args)
        {
            int startYear = int.Parse(Console.ReadLine());
            int endYear = int.Parse(Console.ReadLine());
            int weight = int.Parse(Console.ReadLine());
            bool found = false;
            DateTime startDate = new DateTime(startYear, 1, 1);
            //int d1 = 0;
            //int d2 = 0;
            //int d3 = 0;
            //int d4 = 0;
            //int d5 = 0;
            //int d6 = 0;
            //int d7 = 0;
            //int d8 = 0;
            while (startDate.Year <= endYear)
            {
                int totalWeight = 0;
                string dateString = startDate.ToString("ddMMyyyy");

                for (int i = 0; i < length; i++)
                {
                    for (int i = 0; i < length; i++)
                    {

                    }
                }
                //d1 = startDate.Day / 10;
                //d2 = startDate.Day % 10;
                //d3 = startDate.Month / 10;
                //d4 = startDate.Month % 10;
                //d5 = startDate.Year / 1000;
                //d6 = startDate.Year / 100 % 10;
                //d7 = startYear / 10 % 10;
                //d8 = startDate.Year %10;

                //totalWeight = d1 * (d2 + d3 + d4 + d5 + d6 + d7 + d8) + d2 * (d3 + d4 + d5 + d6 + d7 + d8) +
                //    d3 * (d4 + d5 + d6 + d7 + d8) + d4 * (d5 + d6 + d7 + d8) + d5 * (d6 + d7 + d8) + d6 * (d7 + d8) + d7 * d8;



                if(totalWeight == weight)
                {
                    Console.WriteLine(startDate.ToString("dd-MM-yyyy"));
                    found = true;
                }
                startDate = startDate.AddDays(1);
            }
            if (!found)
            {
                Console.WriteLine("No");
            }
        }
    }
}

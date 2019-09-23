using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossingSequences
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int number = int.Parse(Console.ReadLine());
            int step = int.Parse(Console.ReadLine());
            int tribCurrent = c;
            int currentNumber = number;
            while (tribCurrent <= 1000000 && currentNumber <= 1000000)
            {
                if(a == currentNumber || b == currentNumber || c == currentNumber)
                {
                    break;
                }
                else if(tribCurrent < currentNumber)
                {
                    tribCurrent = a + b + c;
                    a = b;
                    b = c;
                    c = tribCurrent;
                }
                else
                {
                    currentNumber += step;
                }

            }
            if(tribCurrent > 1000000 || currentNumber > 1000000)
            {
                Console.WriteLine("No");
            }
            else
            {
                Console.WriteLine(currentNumber);
            }
        }
    }
}

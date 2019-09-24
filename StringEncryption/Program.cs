using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringEncryption
{
    class Program
    {
        static void Main(string[] args)
        {
            char letter = char.Parse(Console.ReadLine());
            Console.WriteLine(Encrypt(letter));
        }

        static string Encrypt(char letter)
        {
            int asciiCode = letter;
            int firstDigit = 0;
            int lastDigit = 0;

            if(asciiCode < 100)
            {
                firstDigit = asciiCode / 10;
            }
            else
            {
                firstDigit = asciiCode / 100;
            }
            lastDigit = asciiCode % 10;

            var x = asciiCode + lastDigit;
            var z = asciiCode - firstDigit;
            return x + ""+ firstDigit+""+lastDigit;
        }
    }
}

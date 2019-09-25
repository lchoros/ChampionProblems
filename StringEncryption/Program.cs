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
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                char letter = char.Parse(Console.ReadLine());
                Console.Write(Encrypt(letter));
            }
        }

        static string Encrypt(char letter)
        {
            int asciiCode = letter;
            int firstDigit = asciiCode / 10;
            int lastDigit = asciiCode % 10;
            if(asciiCode > 99)
            {
                firstDigit = asciiCode / 100;
            }

            int firstLetter = asciiCode + lastDigit;
            int lastLetter = asciiCode - firstDigit;
            return $"{(char)firstLetter}{firstDigit}{lastDigit}{(char)lastLetter}";
        }
    }
}

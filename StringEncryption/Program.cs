using System;

namespace StringEncryption
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string res = string.Empty;
            for (int i = 0; i < n; i++)
            {
                char letter = char.Parse(Console.ReadLine());
                res += Encrypt(letter);
            }
            Console.WriteLine(res);
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

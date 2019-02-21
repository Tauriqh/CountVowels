using System;

namespace CountVowels
{
    class Program
    {
        static void Main(string[] args)
        {
            string word;
            int count = 0;

            Console.Write("Please enter the word!");
            word = Console.ReadLine();

            for (int i = 0; i < word.Length; i++)
            {
                switch (word[i])
                {
                    case 'a': count++; break;
                    case 'e': count++; break;
                    case 'i': count++; break;
                    case 'o': count++; break;
                    case 'u': count++; break;
                    case 'A': count++; break;
                    case 'E': count++; break;
                    case 'I': count++; break;
                    case 'O': count++; break;
                    case 'U': count++; break;
                }
            }

            Console.WriteLine("The number of vowels is {0}",count);
        }
    }
}

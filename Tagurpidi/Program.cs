using System;

namespace Tagurpidi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisseta oma nimi");
            string userName = Console.ReadLine();

            for (int i = userName.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(userName[1]);
            }
;        }
    }
}

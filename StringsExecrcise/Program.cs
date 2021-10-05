using System;

namespace StringsExecrcise
{
    class Program
    {
        static void Main(string[] args)
        {
            string helloWorld = "Hello World!";

            int helloWorldLength = helloWorld.Length;
            Console.WriteLine(helloWorld[0]);
            Console.WriteLine(helloWorld[helloWorld.Length-2]);
        }
    }
}

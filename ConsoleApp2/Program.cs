using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {


            //program küsib kasuataja sisetstada tema eesnime 
            //program kuuvab kasutaja eesnime esimest tähte 
            //program kuuvab kasutaja eesnime viimast tähte

            Console.WriteLine("Mis on su nimi?");
            string firstName = Console.ReadLine();
            Console.WriteLine(firstName[0]);

            int firstNameLength = firstName.Length;
            Console.WriteLine($"Teie nimi on {firstNameLength} sümbolit pikk");

            //viimane tähe indeks = firstNameLength - 1
            Console.WriteLine(firstName[firstNameLength - 1]);
        }
    }
}

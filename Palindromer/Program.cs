using System.Runtime.InteropServices;

namespace Palindromer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Indtast en tekst streng for at tjekke om der er tale, om et palindrom:");

            string orginal = Convert.ToString(Console.ReadLine());
            string svar = orginal;
            svar.ToLower();

            string omvendt = new string(svar.Reverse().ToArray());
            bool tjek = svar == omvendt;
            if (tjek) {
                Console.WriteLine($"{orginal} er et palindrom"); 
                       }
            else 
            { 
                Console.WriteLine($"{orginal} er IKKE et palindrom"); 
            }

        }
    }
}
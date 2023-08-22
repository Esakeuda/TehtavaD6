using System;

namespace AdditionApp
{
    class Program
    {
        // Metodi laskee kaksi lukua yhteen
        static int AddNumbers(int num1, int num2)
        {
            // Laske kaksi lukua yhteen ja palauta summa
            int sum = num1 + num2;
            return sum;
        }

        static void Main(string[] args)
        {
            // Kysy käyttäjältä ensimmäinen luku
            Console.Write("Syötä ensimmäinen luku: ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            // Kysy käyttäjältä toinen luku
            Console.Write("Syötä toinen luku: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            // Laske lukujen summa käyttämällä AddNumbers-metodia
            int result = AddNumbers(number1, number2);

            // Tulosta laskun tulos
            Console.WriteLine($"Lukujen summa: {result}");
        }
    }
}



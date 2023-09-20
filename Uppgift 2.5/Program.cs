using System;

namespace Uppgift_2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in en multiplikation av två decimaltal på raden nedan");
            string multi = Console.ReadLine();
            int tecken = multi.IndexOf("*");
            string tal1Text = multi[..tecken];
            string tal2Text = multi[(tecken + 1)..];

            float tal1 = float.Parse(tal1Text);
            float tal2 = float.Parse(tal2Text);
            float summa = tal1 * tal2;

            Console.WriteLine(multi + "=" + summa);

            Console.ReadKey();
        }
    }
}
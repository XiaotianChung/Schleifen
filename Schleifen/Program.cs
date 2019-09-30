using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schleifen
{
    class Program
    {
        static void Main(string[] args)
        {
            int zahl;
            Console.WriteLine("Geben Sie eine ganze Zahl:");
            zahl = Convert.ToInt32(Console.ReadLine());

            //i++ bedeutet i+1
            //i--
            for (int i = 0; i <= zahl; i++)
            {
                Console.Write(i + " ");
            }

            //eine zahl abfragen, dass alle Zahlen die kleiner sind ausgeben
            //Variante 1
            int[] zahl1 = new int[7];
            //Variante 2
            int[] zahl2 = new int[7] { 1, 2, 3, 4, 5, 6, 7 };
            //Variante 3
            int[] zahl3 = { 12, 13, 14, 15, 16, 17, 18 };

            for (int i = 0; i < zahl1.Length; i++)
            {
                Console.WriteLine(zahl1[i]);
            }
            for (int i = 0; i < zahl2.Length; i++)
            {
                Console.WriteLine(zahl2[i]);
            }
            for (int i = 0; i < zahl3.Length; i++)
            {
                Console.WriteLine(zahl3[i]);
            }


            int länge;
            Console.WriteLine("Länge der Namensliste angeben:");
            länge = Convert.ToInt32(Console.ReadLine());
            string[] Namen= new string[länge];
            for (int i = 1; i <= länge; i++)
            {
                Console.WriteLine(i + "ten Namen eingeben:");
                Namen[i] = Console.ReadLine();
            }











            Console.ReadKey();
        }
    }
}

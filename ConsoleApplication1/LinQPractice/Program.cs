using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] first = new string[] { "hello", "hi", "good evening", "good day", "good morning", "goodbye" };
            string[] second = new string[] { "whatsup", "how are you", "hello", "bye", "hi" };

            IEnumerable<string> intersect = first.Intersect(second);
            foreach (string value in intersect)
            {
                Console.WriteLine(value);
            }
            Console.ReadLine();
            Console.WriteLine("Fin Ejercicio 1");

            //The ‘intersect’ variable will include “hello” and “hi” as they are common elements to both arrays.


            //----------------------------------------------

            string[] bands = { "ACDC", "Queen", "Aerosmith", "Iron Maiden", "Megadeth", "Metallica", "Cream", "Oasis", "Abba", "Blur", "Chic", "Eurythmics", "Genesis", "INXS", "Midnight Oil", "Kent", "Madness", "Manic Street Preachers", "Noir Desir", "The Offspring", "Pink Floyd", "Rammstein", "Red Hot Chili Peppers", "Tears for Fears", "Deep Purple", "KISS" };

            string[] bandsTwo = { "ACDC", "Queen", "Aerosmith", "Iron Maiden", "Megadeth", "Metallica", "Cream", "Oasis", "Abba", "Blur", "Chic", "Eurythmics", "Genesis", "INXS", "Midnight Oil", "Kent", "Madness", "Manic Street Preachers", "Noir Desir", "The Offspring", "Pink Floyd", "Rammstein", "Red Hot Chili Peppers", "Tears for Fears", "Deep Purple", "KISS" };

            bool equal = bands.SequenceEqual(bandsTwo);

            Console.WriteLine(equal);
            Console.WriteLine("Fin Ejercicio 2");
            Console.ReadLine();

            //If you’d like to check whether the two sequences include the same elements then you can use the SequenceEquals LINQ operator:

            //---------------------------------------------

            first = new string[] { "hello", "hi", "good evening", "good day", "good morning", "goodbye" };
            second = new string[] { "whatsup", "how are you", "hello", "bye", "hi" };

            IEnumerable<string> union = first.Union(second);

            foreach (string value in union)
            {
                Console.WriteLine(value);
            }
            Console.ReadLine();
            Console.WriteLine("Fin Ejercicio 3");

            //You’d then like to join the two sequences containing the values from both but filtering out duplicates. Here’s how to achieve that with the first prototype of the LINQ Union operator:

            //---------------------------------------------




        }
    }
}

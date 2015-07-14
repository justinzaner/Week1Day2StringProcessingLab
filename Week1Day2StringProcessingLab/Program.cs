using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_7_String_Processing_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            // Count the words in the sentence.
            int size = args.Length;

            //Print the words in reverse order, add a space after each word.
            for (int x = size - 1; x >= 0; x--)
            {
                Console.Write(args[x] + " ");
            }
            //Advance to next line
            Console.WriteLine();

            //Write every word from the command line in all uppercase, then print.
            string myString = (args[0] + " " + args[1] + " " + args[2] + " " + args[3]);
            Console.WriteLine(myString.ToUpper());

            // Concatenate every string on the command line as one string, separated by commas. Then print.
            string commaString = (args[0] + ", " + args[1] + ", " + args[2] + ", " + args[3]);
            Console.WriteLine(commaString);

            // Readline to stop program from closing in visual studio
            Console.ReadLine();
        }
    }
}
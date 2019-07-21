using System;
using System.Linq;

namespace ExtensionMethods
{
    public static class Program
    {
        static void Main(string[] args)
        {
            //Write an extension method to check if a string starts with a capital letter or not.
            string b = "Baubau";
            Console.WriteLine($"String start's with capital letter?: Answere is {b.CapitalLetter()}");

            //Write an extension method that appends an ‘s’ to a string.
            string bb = "Justin";
            Console.WriteLine($"Adding an s to the string will lok like : {bb.AppendAnS()}");

            // Write an extension method that will capitalize a word
            string bbb = "miaumiau";
            Console.WriteLine($"Now miaumiau will become {bbb.CapitalizeAWord()}");

            // Write an extension method what will count the number of characters in a string
            string bbbb = "_programarea este cool_";
            var nrChar = bbbb.Count();
            Console.WriteLine($"Nr of char in {bbbb} is {nrChar} char.");

            //Write aprogram that will capitalize a string, and pluralize the same string.
            //You cand write a new extension method or use what you already have
            string bbbbb = "hamham";
            Console.WriteLine($"Capitalize and Pluralized string is: {bbbbb.PluralizeCapitalize()}");

            //Write an extension method that will apply a VAT of 24% on an input.This input can be a decimal value, or an integer on
            decimal nr = 100M;
            Console.WriteLine($"Vat value is:{nr.VAT()} %");
        }

        //Write an extension method to check if a string starts with a capital letter or not.
        public static bool CapitalLetter(this string newstring)
        {
            if (newstring != string.Empty)
            {
                if (newstring[0] == char.ToUpper(newstring[0]))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }

        //Write an extension method that appends an ‘s’ to a string.
        public static string AppendAnS(this string anothernewone)
        {
            return anothernewone.Insert((anothernewone.Length), "s");
        }

        // Write an extension method that will capitalize a word
        public static string CapitalizeAWord(this string bbb)
        {
            return bbb.ToUpper();
        }

        //Write aprogram that will capitalize a string, and pluralize the same string.
        //You cand write a new extension method or use what you already have
        public static string PluralizeCapitalize(this string aString)
        {
            return aString.CapitalizeAWord().AppendAnS();
        }

        // Write an extension method what will count the number of characters in a string
        public static string CountNrChar(this string bbbb)
        {
            return bbbb.CountNrChar();
        }

        //Write an extension method that will apply a VAT of 24% on an input.This input can be a decimal value, or an integer on
        public static decimal VAT(this decimal input)
        {
            return 0.24M * input;
        }
    }
}


using System;
using System.Collections;

namespace ConsoleApp32
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList ProgrammingLanguage = new SortedList();

            ProgrammingLanguage.Add(1964, "Basic");
            ProgrammingLanguage.Add(1966, "JOSS");
            ProgrammingLanguage.Add(1962, "APL");
            ProgrammingLanguage.Add(2001, "C#");
            ProgrammingLanguage.Add(1969, "MUMPS");
            ProgrammingLanguage.Add(1954, "IPL");

            Console.WriteLine("Illere gore: ");

            foreach (DictionaryEntry item in ProgrammingLanguage)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }

            SortedList ProgrammingLanguage1 = new SortedList();

            ProgrammingLanguage1.Add("Basic", 1964);
            ProgrammingLanguage1.Add("JOSS", 1963);
            ProgrammingLanguage1.Add("APL", 1962);
            ProgrammingLanguage1.Add("C#", 2001);
            ProgrammingLanguage1.Add("MUMPS", 1966);
            ProgrammingLanguage1.Add("IPL", 1954);

            Console.WriteLine("Adlara gore: ");

            foreach (DictionaryEntry item in ProgrammingLanguage1)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }
        }
    }
}
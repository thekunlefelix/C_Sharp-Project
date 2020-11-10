using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Q1_Q4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //Q1
            //program to display the characters and frequency of character from giving string

            Console.WriteLine("Input the string: ");
            string sentence = Console.ReadLine();

            if (sentence != "")
            {
                var sentenceList = sentence.GroupBy(a => a).ToList();

                Console.WriteLine("The frequency of the characters are : ");
                foreach (var cha in sentenceList)
                {
                    Console.WriteLine("Character " + cha.Key + " : " + cha.Count() + " time(s)");
                }
            }
            else
            {
                Console.WriteLine("Check your input");
            }
            Console.ReadKey();

            */

            /*
            //Q2
            //program to display the list of items in the array according to the length of the string then by name in ascending order

            string[] arr = {"NAIROBI", "ROME", "AMSTERDAM", "PARIS", "LONDON", "ABU DHABI", "ZURICH", "CALIFORNIA", "NEW DELHI"};

            var orderedArr = arr.OrderBy(a => a.Length).ThenBy(b => b.First()).ToList();
            foreach (var item in orderedArr)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
            */

            /*
            //Q3
            //program to exchange the first and last characters in a given string and return the new string
            Console.WriteLine("Input the string: ");
            string oldString = Console.ReadLine().Trim();
            string newString = "";

            if (oldString != "")
            {
                if (oldString.Length == 1)
                {
                    newString = oldString;
                }
                else
                {
                    char firstChar = oldString.First();
                    char lastChar = oldString.Last();
                    string middle = oldString.Substring(1, (oldString.Length - 2));

                    newString = lastChar.ToString() + middle + firstChar.ToString();
                }
            }
            else
            {
                Console.WriteLine("Check your input");
            }

            Console.WriteLine("New String after manipulation is: " + newString);
            Console.ReadKey();
            */

            //Q4
            //program to check whether an alphabet is a vowel or consonant
            char[] alphabets = {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

            Console.WriteLine("Input any letter of the alphabet: ");
            char letter = Convert.ToChar(Console.ReadLine());

            if (alphabets.Contains(char.ToLower(letter)))
            {
                if (vowels.Contains(char.ToLower(letter)))
                {
                    Console.WriteLine("The alphabet is a vowel");
                } else
                {
                    Console.WriteLine("The alphabet is a consonant");
                }
            }
            else
            {
                Console.WriteLine("Input is not an alphabet");
            }

            Console.ReadKey();
        }
    }
}
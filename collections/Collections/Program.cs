using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numArray = { 0, 1, 2, 3, 4, 6, 7, 8, 9 };
            Console.WriteLine(numArray[2]);
            string[] names = new string[] { "Tim", "Martin", "Nikki", "Sara" };
            Console.WriteLine(names[3]);
            bool[] truefalse = new bool[] { true, false, true, false, true, false, true, false, true, false };
            Console.WriteLine(truefalse[6]);

            List<string> flavors = new List<string>();
            flavors.Add("Vanilla");
            flavors.Add("Chocolate");
            flavors.Add("Cookie Dough");
            flavors.Add("Chocolate Chip");
            flavors.Add("Mint");
            Console.WriteLine(flavors[2]);
            Console.WriteLine(flavors.Count);

            Dictionary<string, string> profile = new Dictionary<string, string>();
            profile.Add("Tim", "Vanilla");
            profile.Add("Martin", "Chocolate");
            profile.Add("Nikki", "Cookie Dough");
            profile.Add("Sara", "Mint");
            foreach (KeyValuePair<string, string> entry in profile)
            {
                Console.WriteLine(entry.Key + " - " + entry.Value);
            }
        }
    }
}

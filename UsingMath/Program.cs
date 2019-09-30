using System;
using System.Collections.Generic;

namespace HRRepeatedString {

    class Program {

        static void Main(string[] args) {

            // this attempt fails. Too inefficient

            string s = "abc";
            s = s.ToLower();
            string letter = "a";
            int n = 10;
            int counter = 0;
            int target = 0;
            List<char> charlist = new List<char>();

            foreach (char c in s) {
                charlist.Add(c);
            }

            while (counter < n) {
                foreach (char c in charlist) {
                    if (c.ToString().Equals(letter)) {
                        target++;
                    }
                    counter++;
                    if (counter == n + 1) {
                        break;
                    }
                    Console.Write($"{c.ToString()}, {counter}, {target}");
                    Console.WriteLine();
                }
            }
        }
    }
}

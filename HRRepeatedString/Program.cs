using System;
using System.Collections.Generic;
using System.Linq;

namespace HRRepeatedString {

    class Program {

        static void Main(string[] args) {

            // fails test case 5 & 20. Don't know what the input of those is to fix code

            string s = "abcba";
            s = s.ToLower();
            int strLen = s.Length;
            char letter = 'a';
            long n = 100000000000; 
            
            
            IList<char> charlist = new List<char>();

            foreach (char c in s) {
                charlist.Add(c);
            }

            if (strLen == 1)
            {
                Console.WriteLine(n);
            }

            int appearances = charlist.Where(c => c.Equals(letter)).Count();
            long fullReps = (n / strLen); 
            long charsRem = (n % strLen);

            List<char> remList = (List<char>)charlist;
            long counter = 0;
            long remAppear = 0;
            while (counter < charsRem) {
                foreach(char c in charlist) {
                    if (c.Equals(letter)) {
                        remAppear++;                        
                    }
                    counter++;
                    if (counter == charsRem) {
                        break;
                    }
                }
            }            

            long totalAppear = (appearances * fullReps) + remAppear;
            Console.WriteLine(totalAppear);
        }
    }
}

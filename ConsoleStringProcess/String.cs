using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleStringProcess
{
    /// <summary>
    /// String Utility will provide character counts 
    /// and display counts in given format.
    /// </summary>
    public class StringUtility
    {
        private string input;
        private static int SIZE = 26;
        private int totalChar;
        private int[] freq = new int[SIZE];
        private StringBuilder alphabets, charFrequency;
        
        /// <summary>
        /// Initialize with input argument and required objects
        /// </summary>
        /// <param name="arg"></param>
        public StringUtility(string arg)
        {
            input = arg.ToLower();
            alphabets = new StringBuilder();
            charFrequency = new StringBuilder();
        }
        /// <summary>
        /// Function will count characters frequency.
        /// </summary>
        public void CountCharFrequency()
        {
            for(int i=0; i< input.Length; i++)
            {
                if (input[i] - 'a' >= 0 && input[i] - 'a' <= SIZE)
                {
                    freq[input[i] - 'a']++;
                    totalChar++;
                }
            }
        }

        /// <summary>
        /// Print character frequency in required formate on console.
        /// </summary>
        public void PrintCharFrequency()
        {
            alphabets.Append("| ");
            charFrequency.Append("| ");
            for (int i = 0; i < SIZE; i++)
            {
                alphabets.Append( Convert.ToChar(i + 'a') + " | " );
                charFrequency.Append(freq[i] + " | ");
            }

            Console.WriteLine("Input text: {0}", input);
            Console.WriteLine(alphabets.ToString());
            Console.WriteLine(charFrequency.ToString());
            Console.WriteLine("The text has been processed." +
                "Total letters counted: {0}", totalChar);
        }
    }
}

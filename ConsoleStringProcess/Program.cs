using System;

namespace ConsoleStringProcess
{
    class Program
    {
        /// <summary>
        /// Input string arg to count characters and display in the given format.
        /// </summary>
        /// <param name="args1">Input string arg.</param>
        static void Main(string[] args)
        {
            if(args.Length == 1)
            {
                StringUtility strProcess = new StringUtility(args[0]);

                strProcess.CountCharFrequency();
                strProcess.PrintCharFrequency();
            }

            Console.WriteLine("Provide only single input argument!");
        }
    }
}

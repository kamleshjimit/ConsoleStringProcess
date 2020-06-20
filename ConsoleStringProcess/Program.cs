using System;

namespace ConsoleStringProcess
{
    class Program
    {
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

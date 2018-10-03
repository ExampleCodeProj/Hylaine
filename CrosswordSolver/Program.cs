using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace CrosswordSolver
{
    //***********************************Instructions********************************
    /*
             *Implement a Crossword Solver
             * 1. User needs to be able to input the word length, and a combination of known letters and wildcards. 
             *  The input format should use an asterisk: '*' (U+002A) as a wildcard.
             *  Make this simple!
             *  
             * 2. The program should return all words in the dictionary that match the input pattern. 
             *      This means you won't be solving a whole crossword - just providing options for what would 
             *      fit in a crossword row or column.
             *      
             *   Example Input: bee*
             *   Output: Found 5 words in 1000 ms: Beef, Been, Beep, Beer, Bees, Beet
             *   
             *   Example Input: *eel
             *   Output: Found 8 words in 1000 ms: Feel, Heel, Keel, Peel, Reel, Seel, Teel, Weel
             *   
             * 3. An example dictionary .csv is included for your convenience. You can/should use the default .NET libraries to load it.
             * 4. Using the stopwatch, be sure to indicate how long your solution takes to load its structures, and produce a result. 
             *      Hint: display the time to process a result AFTER printing them out, otherwise you won't be able to see it in large result sets.
             * 
             * A few final points:
             * 1. The order of priorities for the solution should be: Correctness, Performance, elegance, and usability.
             * 2. Startup time and memory usage are much less important than the time taken to solve the crossword pattern (which is critical).
             * 3. Error handling and input validation are "nice to haves", as long as your control schemes and instructions are clear.
             * 4. Do not change the method signature or parameters of GetPossibleWords. In other words your solution should be built around this method.
             * 
             */
    class Program
    {
        static void Main(string[] args)
        {
            var sw = new Stopwatch();

            var path = @".\english.csv";
            var wordList = File.ReadLines(path);

            Console.WriteLine("Enter a partial word pattern using the * wildcard as a placeholder for any key.");
            var charPattern = Console.ReadLine().ToUpper() ?? throw new ArgumentNullException("Console.ReadLine().ToUpper()");
           
            var solutionSet = new List<string>();

            foreach (var word in wordList)
            {
                var isSolution = true;
                if (word.Length != charPattern.Length)
                    continue;
                for (var i = 0; i < charPattern.Length; i++)
                {
                    if (charPattern[i] == '*')
                        continue;
                    if (charPattern[i] != word[i])
                    {
                        isSolution = false;
                        break;
                    }
                }
                if (isSolution)
                {
                    solutionSet.Add(word);
                }
            }

            foreach (var item in solutionSet)
            {
                Console.Write(item + ' ');
            }

        }
        public static List<string> GetPossibleWords(string template, List<string> dict)
        {
            return new List<string>();
        }
    }
}

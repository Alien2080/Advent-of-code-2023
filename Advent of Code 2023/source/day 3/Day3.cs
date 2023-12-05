using System.Net.Http.Headers;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;

namespace solutions
{
    public partial class Day3
    {
        private static readonly string inputFilePath = Path.Combine(Environment.CurrentDirectory, @"source\day 3\input.txt");

        public static void Puzzle1()
        {
            string input = File.ReadAllText(inputFilePath);  
            var inputArray = Create2Darray(input);

            int total = 0;

            int rowIndex = 0;
            int columnIndex;

            foreach (var line in inputArray)
            {
                columnIndex = 0;

                foreach (var character in line)
                {
                    if (!char.IsNumber(character) && character != '.')
                    {
                        // check row above.
                        if (rowIndex - 1 > 0)
                        {
                            if (columnIndex -1 > 0 && char.IsNumber(inputArray[(rowIndex-1)][columnIndex-1]))
                            {

                            }
                            if (char.IsNumber(inputArray[(rowIndex-1)][columnIndex]))
                            {

                            }
                            if (columnIndex + 1 < line.Length && char.IsNumber(inputArray[(rowIndex-1)][columnIndex+1]))
                            {

                            }
                        } 

                        // check same row.

                        // check row below.

                    }
                    
                    columnIndex++;
                }

                rowIndex++;
            }

            Console.WriteLine("Day 2, puzzle 1: " + total);
        }


        public static void Puzzle2()
        {

            Console.WriteLine("Day 2, puzzle 2: " + total);
        }

        private static char[][] Create2Darray(string input)
        {
            var data = input
                    .Split(Environment.NewLine)
                    .Select(s => s.ToCharArray())
                    .ToArray();
            
            return data;
        }
    }
}
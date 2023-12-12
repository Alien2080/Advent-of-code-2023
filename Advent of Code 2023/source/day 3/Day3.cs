using System.Net.Http.Headers;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;

namespace solutions
{
    public partial class Day3
    {
        private static readonly string inputFilePath = Path.Combine(Environment.CurrentDirectory, @"..\..\..\source\day 3\input.txt");

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
                        bool spaceBetweenDigits = true;
                        // Check row above.
                        if (rowIndex - 1 >= 0)
                        {
                            if (columnIndex - 1 >= 0 && char.IsNumber(inputArray[rowIndex - 1][columnIndex - 1]))
                            {
                                spaceBetweenDigits = false;
                                total += GetNumberAtLocation(inputArray, rowIndex - 1, columnIndex - 1);
                            }
                            if (char.IsNumber(inputArray[rowIndex - 1][columnIndex]))
                            {
                                if (spaceBetweenDigits)
                                {
                                    spaceBetweenDigits = false;
                                    total += GetNumberAtLocation(inputArray, rowIndex - 1, columnIndex);
                                }
                            }
                            else
                            {
                                spaceBetweenDigits = true;
                            }
                            if (columnIndex + 1 < line.Length && char.IsNumber(inputArray[rowIndex - 1][columnIndex + 1]))
                            {
                                if (spaceBetweenDigits)
                                {
                                    spaceBetweenDigits = false;
                                    total += GetNumberAtLocation(inputArray, rowIndex - 1, columnIndex + 1);
                                }
                            }
                            else
                            {
                                spaceBetweenDigits = true;
                            }
                        }

                        // Check same row.
                        if (columnIndex - 1 >= 0 && char.IsNumber(inputArray[rowIndex][columnIndex - 1]))
                        {
                            total += GetNumberAtLocation(inputArray, rowIndex, columnIndex - 1);
                        }
                        if (columnIndex + 1 < line.Length && char.IsNumber(inputArray[rowIndex][columnIndex + 1]))
                        {
                            total += GetNumberAtLocation(inputArray, rowIndex, columnIndex + 1);
                        }

                        // Check row below.
                        if (rowIndex + 1 < inputArray.Length)
                        {
                            spaceBetweenDigits = true;
                            if (columnIndex - 1 >= 0 && char.IsNumber(inputArray[rowIndex + 1][columnIndex - 1]))
                            {
                                spaceBetweenDigits = false;
                                total += GetNumberAtLocation(inputArray, rowIndex + 1, columnIndex - 1);
                            }
                            if (char.IsNumber(inputArray[rowIndex + 1][columnIndex]))
                            {
                                if (spaceBetweenDigits)
                                {
                                    spaceBetweenDigits = false;
                                    total += GetNumberAtLocation(inputArray, rowIndex + 1, columnIndex);
                                }
                            }
                            else
                            {
                                spaceBetweenDigits = true;
                            }
                            if (columnIndex + 1 < line.Length && char.IsNumber(inputArray[rowIndex + 1][columnIndex + 1]))
                            {
                                if (spaceBetweenDigits)
                                {
                                    spaceBetweenDigits = false;
                                    total += GetNumberAtLocation(inputArray, rowIndex + 1, columnIndex + 1);
                                }
                            }
                            else
                            {
                                spaceBetweenDigits = true;
                            }
                        }
                    }
                    columnIndex++;
                }
                rowIndex++;
            }

            Console.WriteLine("Day 2, puzzle 1: " + total);
        }

        public static void Puzzle2()
        {

            // Console.WriteLine("Day 2, puzzle 2: " + total);
        }

        private static char[][] Create2Darray(string input)
        {
            var data = input
                    .Split(Environment.NewLine)
                    .Select(s => s.ToCharArray())
                    .ToArray();

            return data;
        }

        private static int GetNumberAtLocation(char[][] inputArray, int row, int column)
        {
            int index = 1;
            List<char> result = inputArray[row][column].ToString().ToList();

            // Check is chars before are numbers.
            while (column - index >= 0 && char.IsNumber(inputArray[row][column - index]))
            {
                result.Insert(0, inputArray[row][column - index]);
                index++;
            }

            // Check is chars after are numbers.
            index = 1;
            while (column + index < inputArray[row].Length && char.IsNumber(inputArray[row][column + index]))
            {
                result.Add(inputArray[row][column + index]);
                index++;
            }

            return int.Parse(new string(result.ToArray()));
        }
    }
}
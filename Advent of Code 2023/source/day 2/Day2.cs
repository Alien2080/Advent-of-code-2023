using System.Text.RegularExpressions;

namespace solutions
{
    public partial class Day2
    {
        public static void Puzzle1()
        {
            string filePath = @"..\..\..\source\day 2\input.txt";    
            string input = File.ReadAllText(filePath);     

            string[] games = input.Split(Environment.NewLine);

            int highestRed;
            int highestBlue;
            int highestGreen;
            int total = 0;
            int index = 1;

            foreach (string game in games)
            {
                highestRed = 0;
                highestBlue = 0;
                highestGreen = 0;               

                // Get rid of the 'Game XX:' bit at the start of the line.
                string setsLine = game.Split(":")[1];
                string[] sets = setsLine.Split(new char[] { ',', ';' });

                foreach (string set in sets)
                {
                    int value;
                    if (set.Contains("red"))
                    {
                        value = int.Parse(FirstDigits().Match(set).Value);
                        if (value > highestRed)
                        {
                            highestRed = value;
                        }
                    }
                    else if (set.Contains("blue"))
                    {
                        value = int.Parse(FirstDigits().Match(set).Value);
                        if (value > highestBlue)
                        {
                            highestBlue = value;
                        }
                    }
                    else if (set.Contains("green"))
                    {
                        value = int.Parse(FirstDigits().Match(set).Value);
                        if (value > highestGreen)
                        {
                            highestGreen = value;
                        }
                    }
                }

                if (highestRed <= 12 && highestGreen <= 13 && highestBlue <= 14)
                {
                    total += index;
                }

                index++;
            }
            Console.WriteLine("Day 2, puzzle 1: " + total);
        }

        public static void Puzzle2()
        {
            string filePath = @"..\..\..\source\day 2\input.txt";    
            string input = File.ReadAllText(filePath);     

            string[] games = input.Split(Environment.NewLine);

            int highestRed;
            int highestBlue;
            int highestGreen;
            int total = 0;

            foreach (string game in games)
            {
                highestRed = 0;
                highestBlue = 0;
                highestGreen = 0;               

                // Get rid of the 'Game XX:' bit at the start of the line.
                string setsLine = game.Split(":")[1];
                string[] sets = setsLine.Split(new char[] { ',', ';' });

                foreach (string set in sets)
                {
                    int value;
                    if (set.Contains("red"))
                    {
                        value = int.Parse(FirstDigits().Match(set).Value);
                        if (value > highestRed)
                        {
                            highestRed = value;
                        }
                    }
                    else if (set.Contains("blue"))
                    {
                        value = int.Parse(FirstDigits().Match(set).Value);
                        if (value > highestBlue)
                        {
                            highestBlue = value;
                        }
                    }
                    else if (set.Contains("green"))
                    {
                        value = int.Parse(FirstDigits().Match(set).Value);
                        if (value > highestGreen)
                        {
                            highestGreen = value;
                        }
                    }
                }
                
                int powerOfSet = highestRed * highestGreen * highestBlue;
                total += powerOfSet;
            }
            Console.WriteLine("Day 2, puzzle 2: " + total);
        }

        [GeneratedRegex("\\d+")]
        private static partial Regex FirstDigits();
    }
}
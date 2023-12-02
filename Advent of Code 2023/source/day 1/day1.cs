using System.Data.Common;

namespace solutions
{
    public class Day1
    {
        public static void Puzzle1()
        {
            string filePath = @"..\..\..\source\day 1\input.txt";
            var input = File.ReadAllText(filePath);
            string[] lines = input.Split(Environment.NewLine);

            int total = 0;
            int? firstNumber;
            int? secondnumber;

            foreach (string line in lines)
            {
                firstNumber = null;
                secondnumber = null;
                char[] letters = line.ToCharArray();   

                foreach (char letter in letters)
                {
                    if (char.IsNumber(letter) == true)
                    {
                        firstNumber ??= int.Parse(letter.ToString());
                        secondnumber = int.Parse(letter.ToString());
                    }     
                } 
                total += int.Parse(firstNumber.ToString() + secondnumber.ToString());
            }
            Console.WriteLine("Day 1, puzzle 1: " + total);
        }

        public static void Puzzle2()
        {
            string filePath = @"..\..\..\source\day 1\input.txt";
            var input = File.ReadAllText(filePath);
            string[] lines = input.Split(Environment.NewLine);

            int total = 0;
            int? firstNumber;
            int? secondnumber;
            int index;

            foreach (string line in lines)
            {
                char[] letters = line.ToCharArray(); 

                firstNumber = null;
                secondnumber = null;
                index = 0;   

                foreach (char letter in letters)
                {
                    if (char.IsNumber(letter) == true)
                    {
                        firstNumber ??= int.Parse(letter.ToString());
                        secondnumber = int.Parse(letter.ToString());
                    }
                    else if (index + 3 <= letters.Length)
                    {
                        switch(new String(letters[index..(index+3)]).ToLower()) 
                        {
                        case "one":
                            firstNumber ??= 1;
                            secondnumber = 1;
                            break;
                        case "two":
                            firstNumber ??= 2;
                            secondnumber = 2;
                            break;
                        case "thr":
                            if (index + 5 <= letters.Length && new String(letters[index..(index+5)]).ToLower() == "three")
                            {
                                firstNumber ??= 3;
                                secondnumber = 3;
                            }                        
                            break;
                        case "fou":
                            if (index + 4 <= letters.Length && new String(letters[index..(index+4)]).ToLower() == "four")
                            {
                                firstNumber ??= 4;
                                secondnumber = 4;
                            }
                            break;
                        case "fiv":
                            if (index + 4 <= letters.Length && new String(letters[index..(index+4)]).ToLower() == "five")
                            {
                                firstNumber ??= 5;
                                secondnumber = 5;
                            }
                            break;
                        case "six":
                            firstNumber ??= 6;
                            secondnumber = 6;
                            break;
                        case "sev":
                            if (index + 5 <= letters.Length && new String(letters[index..(index+5)]).ToLower() == "seven")
                            {
                                firstNumber ??= 7;
                                secondnumber = 7;
                            }
                            break;
                        case "eig":
                            if (index + 5 <= letters.Length && new String(letters[index..(index+5)]).ToLower() == "eight")
                            {
                                firstNumber ??= 8;
                                secondnumber = 8;
                            }
                            break;
                        case "nin":
                            if (index + 4 <= letters.Length && new String(letters[index..(index+4)]).ToLower() == "nine")
                            {
                                firstNumber ??= 9;
                                secondnumber = 9;
                            }
                            break;
                        }
                    }
                    index++;
                } 
                total += int.Parse(firstNumber.ToString() + secondnumber.ToString());
                
            }
            Console.WriteLine("Day 1, puzzle 2: " + total);
        }
    }
}
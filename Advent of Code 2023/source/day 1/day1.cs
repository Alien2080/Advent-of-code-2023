namespace solutions
{
    public class day1
    {
        public static void day_1_1()
        {
            // Move the current directory up 3 places.
            Directory.SetCurrentDirectory(@"..\..\..");
            string filePath = @"source\day 1\input.txt";
            var input = File.ReadAllText(filePath);

            string[] lines = input.Split(Environment.NewLine);

            int total = 0;
            int firstNumber;
            int secondnumber;
            bool foundFirst;
            foreach (string line in lines)
            {
                foundFirst = false;
                firstNumber = 0;
                secondnumber = 0;

                char[] letters = line.ToCharArray();

                foreach (char letter in letters)
                {
                    if (char.IsNumber(letter) == true)
                    {
                        if (!foundFirst)
                        {
                            foundFirst = true;
                            firstNumber = int.Parse(letter.ToString());
                            secondnumber = firstNumber;
                        } 
                        else 
                        {
                            secondnumber = int.Parse(letter.ToString());
                        }
                    }     
                } 
                total += int.Parse(firstNumber.ToString() + secondnumber.ToString());
            }
            Console.WriteLine("total: " + total);
        }

        public static void day_1_2()
        {
            // Move the current directory up 3 places.
            Directory.SetCurrentDirectory(@"..\..\..");
            string filePath = @"source\day 1\input.txt";
            var input = File.ReadAllText(filePath);

            string[] lines = input.Split(Environment.NewLine);

            int total = 0;
            int firstNumber;
            int secondnumber;
            bool foundFirst;
            foreach (string line in lines)
            {
                foundFirst = false;
                firstNumber = 0;
                secondnumber = 0;

                char[] letters = line.ToCharArray();

                foreach (char letter in letters)
                {
                    if (char.IsNumber(letter) == true)
                    {
                        if (!foundFirst)
                        {
                            foundFirst = true;
                            firstNumber = int.Parse(letter.ToString());
                            secondnumber = firstNumber;
                        } 
                        else 
                        {
                            secondnumber = int.Parse(letter.ToString());
                        }
                    }     
                } 
                total += int.Parse(firstNumber.ToString() + secondnumber.ToString());
            }
            Console.WriteLine("total: " + total);
        }
    }
}
namespace Labb_1___Jonas_Haggu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input ");
            string input;
            input = Console.ReadLine();

            int i = 0;
            long sum = 0;
            // För att consolen ska klara av att räkna ut större tal (int32.parse är inte optimal för detta)

            while (i < input.Length)
            {
                char currentDigit = input[i];
                int indexOfFirstDigitSameasThisDigit = input.IndexOf(currentDigit, i + 1);
                if (indexOfFirstDigitSameasThisDigit != -1)
                {
                    string possibleCorrectSubstring = input.Substring(i, indexOfFirstDigitSameasThisDigit - i + 1);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write(input.Substring(0, i));
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(possibleCorrectSubstring);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write(input.Substring(indexOfFirstDigitSameasThisDigit + 1, input.Length - indexOfFirstDigitSameasThisDigit - 1));
                    Console.WriteLine();

                    sum += long.Parse(possibleCorrectSubstring);
                }
                i++;

            }
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Sum of the numbers: " + sum);
        }

    }

}
        
    

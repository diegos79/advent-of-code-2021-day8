using System;

namespace AdventOfCodeDay8Part2
{
    class Program
    {
        public static void Main()
        {
            var inputDigits = AOCD8P2.ExtractInputDigits();
            var outputDigits = AOCD8P2.ExtractOutputDigits();
            int row = 0;
            string outputValue = "";
            int outputValueInt = 0;
            int totalOutput = 0;
            foreach (var item in outputDigits)
            {
                int i, j = 0;
                string l7 = "";
                string l4 = "";
                for (j = 0; j < inputDigits[row].Length; j++)
                {
                    Console.WriteLine($"{inputDigits[row][j]}");
                    if (inputDigits[row][j].Length == 4)
                        l4 = inputDigits[row][j];
                    if (inputDigits[row][j].Length == 3)
                        l7 = inputDigits[row][j];
                }
                Console.WriteLine($"\nOutput digits alla riga nr. {row}");
                for (i = 0; i < item.Length; i++)
                {
                    Console.WriteLine($"{item[i]}");
                    Console.WriteLine(AOCD8P2.DecodeDigitString(item[i], l7, l4));
                    outputValue += AOCD8P2.DecodeDigitString(item[i], l7, l4);
                }
                outputValueInt = int.Parse(outputValue);
                outputValue = "";
                totalOutput += outputValueInt;
                row++;
                Console.WriteLine(totalOutput);
            }
        }
    }
}

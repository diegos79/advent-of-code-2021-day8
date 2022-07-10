using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCodeDay8Part2
{
    public class AOCD8P2
    {
        public static List<string[]> ExtractInputDigits()
        {
            var allLines = File.ReadAllLines("input.txt");
            var lines = allLines.Select(line => line.Split('|')).ToList();
            List<string> inputDigits = new ();
            for (int i = 0; i < lines.Count; i++)
            {
                inputDigits.Add(lines[i][0]); 
            }
            var b = inputDigits.Select(x => x.Split(' ')).ToList();
            return b;
        }

        public static List<string[]> ExtractOutputDigits()
        {
            var allLines = File.ReadAllLines("input.txt");
            var lines = allLines.Select(line => line.Split('|')).ToList();
            List<string> inputDigits = new();
            for (int i = 0; i < lines.Count; i++)
            {
                inputDigits.Add(lines[i][1].Trim());
            }
            var b = inputDigits.Select(x => x.Split(' ')).ToList();
            return b;
        }

        public static int GetLenghtOfString (string s)
        { 
            return s.Length;
        }

        

        public static string DecodeDigitString(string s, string opt7 = "", string opt4 = "")
        {
            switch (s.Length)
            {
                case 2: return "1";
                case 3: return "7";
                case 4: return "4";
                case 7: return "8";
                case 5:
                    {
                        if (CountCommonChar(opt7, s) == 2 && CountCommonChar(opt4, s) == 2) return "2";
                        else if (CountCommonChar(opt7, s) == 3 && CountCommonChar(opt4, s) == 3) return "3";
                        else return "5";
                    }
                case 6:
                    {
                        if (CountCommonChar(s, opt7) == 2 && CountCommonChar(s, opt4) == 3) return "6";
                        else if (CountCommonChar(s, opt7) == 3 && CountCommonChar(s, opt4) == 4) return "9";
                        else return "0";
                    }
                default: return "-1";

            }
        }

        public static int CountCommonChar (string input, string output)
        {
            int count = 0;
            foreach (var character in input)
            {
                if (output.Contains(character))
                    count++;
            }
            return count;
        }
    }
}

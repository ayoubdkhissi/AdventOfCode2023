using System;

namespace AdventOfCode2023;
public static class Day1
{
    public static int Part1(string[] input)
    {
        int ans = 0;
        foreach (var line in input)
        {
            int firstDigit = GetDigitPart1(line);
            int lastDigit = GetDigitPart1(line, true);

            ans += firstDigit * 10 + lastDigit;
        }
        return ans;
    }

    public static int Part2(string[] input)
    {
        int ans = 0;
        foreach (var line in input)
        {
            int firstDigit = GetDigitPart2(line);
            int lastDigit = GetDigitPart2(line, true);

            ans += firstDigit * 10 + lastDigit;
        }
        return ans;
    }

    private static int GetDigitPart1(string line, bool reverse = false)
    {
        var s = reverse ? line.Reverse() : line;
        foreach(var c in s)
        {
            int a;
            if(int.TryParse(c.ToString(), out a))
            {
                return a;
            }
        }
        return 0;
    }
    
    private static int GetDigitPart2(string line, bool reverse = false)
    {
        Func<string, string, int> indexOfFunction = reverse ? (s, value) => s.LastIndexOf(value) : (s, value) => s.IndexOf(value);
        Func<int, int, bool> condition = reverse ? (index1, index2) => index1 >= index2 : (index1, index2) => index1 < index2;

        int smallest_index = reverse ? 0 : line.Length;
        int ans = 0;
        foreach(var key in Numbers.Keys)
        {
            int indexOfKey = indexOfFunction(line, key);
            if (indexOfKey > -1 && condition(indexOfKey, smallest_index))
            {
                ans = Numbers[key];
                smallest_index = indexOfKey;
            }
        }
        return ans;
    }

    private static Dictionary<string, int> Numbers = new()
    {
        { "one", 1 },
        { "two", 2 },
        { "three", 3},
        { "four", 4 },
        { "five", 5 },
        { "six", 6 },
        { "seven", 7 },
        { "eight", 8 },
        { "nine", 9 },
        { "1", 1 },
        { "2", 2 },
        { "3", 3 },
        { "4", 4 },
        { "5", 5 },
        { "6", 6 },
        { "7", 7 },
        { "8", 8 },
        { "9", 9 }
    };

}

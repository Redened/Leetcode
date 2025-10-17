namespace RomanToInteger;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Solution.RomanToInt("LIV"));
    }
}

public class Solution
{
    public static int RomanToInt(string s)
    {
        var romanToInt = new Dictionary<char, int>
        {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 }
        };

        var intSum = 0;

        for (int i = 0; i < s.Length; i++)
        {
            if (i + 1 < s.Length && romanToInt[s[i]] < romanToInt[s[i + 1]])
            {
                intSum -= romanToInt[s[i]];
            }
            else
            {
                intSum += romanToInt[s[i]];
            }
        }

        return intSum;
    }
}
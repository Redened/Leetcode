namespace LongestCommonPrefix;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Solution.LongestCommonPrefix(["flower", "flow", "flight"]));
    }
}

public class Solution
{
    public static string LongestCommonPrefix(string[] strs)
    {
        string commonPrefix = strs[0];

        for (int i = 1; i < strs.Length; i++)
        {
            while (!strs[i].StartsWith(commonPrefix))
            {
                commonPrefix = commonPrefix.Substring(0, commonPrefix.Length - 1);
            }
        }

        return commonPrefix;
    }
}
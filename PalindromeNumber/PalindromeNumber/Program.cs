namespace PalindromeNumber;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Solution.IsPalindrome(155551));
    }
}

public class Solution
{
    public static bool IsPalindrome(int x)
    {
        if (x < 0 || (x % 10 == 0 && x != 0)) return false;

        var reversedInputString = new string(x.ToString().Reverse().ToArray());

        if (!int.TryParse(reversedInputString, out int reversedInputNumber)) return false;

        if (x == reversedInputNumber) return true;

        return false;
    }
}
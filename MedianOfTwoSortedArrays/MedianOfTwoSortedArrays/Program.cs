namespace MedianOfTwoSortedArrays;

class Program
{
    static void Main(string[] args)
    {
        int[] nums1 = { 1, 2 };
        int[] nums2 = { 3, 4, 5, 6 };

        Console.WriteLine(Solution.FindMedianSortedArrays(nums1, nums2));
    }
}

public class Solution
{
    public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        int totalArrayLength = nums1.Length + nums2.Length;

        if (totalArrayLength == 0) throw new ArgumentException("Both arrays are empty");

        int medianIndexMinimum = (totalArrayLength - 1) / 2;
        int medianIndexMaximum = totalArrayLength / 2;

        int indexForArray1 = 0;
        int indexForArray2 = 0;

        int previousValue = 0;
        int currentValue = 0;

        for (int step = 0; step <= medianIndexMaximum; step++)
        {
            previousValue = currentValue;

            bool takeFromFirstArray =
                indexForArray1 < nums1.Length &&
                (indexForArray2 >= nums2.Length || nums1[indexForArray1] <= nums2[indexForArray2]);

            if (takeFromFirstArray)
            {
                currentValue = nums1[indexForArray1];
                indexForArray1++;
            }
            else
            {
                currentValue = nums2[indexForArray2];
                indexForArray2++;
            }
        }

        if (totalArrayLength % 2 == 1)
            return currentValue;

        return (previousValue + currentValue) / 2.0;
    }
}
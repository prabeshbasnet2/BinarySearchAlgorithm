public class BinarySearch
{
    public static void Main(string[] args)
    {
        int[] myArr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        var binary = ApplyBinarySearch(myArr, 6);
        var steps = ApplyBinarySearch(myArr, 6, true);
        Console.WriteLine("The found value is : {0}", binary);
        Console.WriteLine("The number of steps is : {0}", steps);
    }

    private static int ApplyBinarySearch(int[] nums, int item, bool returnCount = false)
    {
        int low = 0;
        int high = nums.Length - 1;
        int count = 0;
        while (low <= high)
        {
            int mid = (low + high) / 2;
            int guess = nums[mid];

            if (guess == item)
            {
                var returnVal = returnCount == true ? count : mid;
                return returnVal;
            }
            else if (guess > item)
            {
                high = mid - 1;
            }
            else
            {
                low = mid + 1;
            }
            count++;
        }
        return 0;


    }
}
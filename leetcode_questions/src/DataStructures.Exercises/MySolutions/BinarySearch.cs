namespace DataStructures.Exercises.MySolutions;

public class BinarySearch
{
    static void Main()
    {
        int[] nums = { -1, 0, 3, 5, 9, 12 };
        int target = 9;
        var BinarySearch = new BinarySearch();
        var result = BinarySearch.Search(nums, target);
        Console.WriteLine(result);
    }
    public int Search(int[] nums, int target)
    {

        int LeftPointer = 0;
        int RightPointer = nums.Length - 1;

        while (LeftPointer <= RightPointer)
        {
            int mid = (RightPointer + LeftPointer) / 2;

            if (mid == target)
                return mid;

            else if (nums[LeftPointer] <= nums[mid])
            {
                if (target < nums[mid] && target > nums[LeftPointer])
                {
                    RightPointer = mid - 1;
                    LeftPointer++;
                }
                else
                {
                    LeftPointer = mid + 1;
                    RightPointer--;
                }
            }
            else
            {
                if (target > nums[mid] && target < nums[RightPointer])
                {
                    LeftPointer = mid + 1;
                    RightPointer--;
                }
                else
                {
                    RightPointer = mid - 1;
                    LeftPointer++;
                }
            }
        }
        return -1;
    }

}

// x
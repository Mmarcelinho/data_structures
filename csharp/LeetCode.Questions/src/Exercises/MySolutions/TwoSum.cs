namespace Exercises.MySolutions;

    public class TwoSum
    {
        // static void Main()
        // {
        //     int[] nums = {3,2,4}; var target = 6;
        //     var TwoSum = new TwoSum();
        //     TwoSum.FindTwoSum(nums, target);
        // }
     public int[] FindTwoSum(int[] nums, int target) {
        
        var listNumbers = new List<int>();
        for(int i = 0; i < nums.Length; i++)
        {
            int current = target - nums[i];
            if (!listNumbers.Contains(current))
                listNumbers.Add(nums[i]);
            else
            {
                var positionIndex = listNumbers.IndexOf(current);
                return [positionIndex, i];   
            }   
        }
         return new int[] { };
    }   
    
    }

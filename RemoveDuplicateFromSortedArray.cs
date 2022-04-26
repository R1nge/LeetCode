public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int current = 0;
        for(int i = 1; i < nums.Length; i++) 
        {
            if (nums[i] != nums[current]) 
            {
                nums[current + 1] = nums[i];
                current++;   
            }
        }
        return current + 1;
    }
}

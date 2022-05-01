public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var indexies = new int[2];
        for(int i = 0; i < nums.Length; i++){
            for(int j = i + 1; j < nums.Length; j++){
                if(nums[i] + nums[j] == target){
                    indexies[0] = i;
                    indexies[1] = j;
                    break;
                }
            }
        }
        return indexies;
    }
}

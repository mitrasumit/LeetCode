public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        
        HashSet<int> num=new HashSet<int>(nums);
        
        if(nums.Length==num.Count)
            return false;
        return true;
    }
}
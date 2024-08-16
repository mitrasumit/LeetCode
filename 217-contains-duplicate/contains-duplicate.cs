public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        
        HashSet<int> num=new HashSet<int>(nums);
            return nums.Length==num.Count?false:true;

    }
}
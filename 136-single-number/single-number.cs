public class Solution {
    public int SingleNumber(int[] nums) {

     int xor=0;

     foreach(int num in nums)
     {
        xor=xor^num;
     }

     return xor;

    }
}
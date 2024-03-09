public class Solution {
    public bool IsPalindrome(int x) {
        int sum=0,d=0;
        int t=x;
        while(t>0)
        {
            d=t%10;
            sum=(sum*10)+d;
            t=t/10;
        }
        return sum==x;
    }
}
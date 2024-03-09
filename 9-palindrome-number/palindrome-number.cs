public class Solution {
    public bool IsPalindrome(int x) {
        int sum=0;
        int t=x;
        int d=0;
        if(x<0)
            return false;
        while(t>=10)
        {
            d=t%10;
            sum=(sum*10)+d;
            t/=10;

        }
        sum=(sum*10)+t;
        return sum==x;
    }
}
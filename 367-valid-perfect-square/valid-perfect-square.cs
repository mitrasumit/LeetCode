public class Solution {
    public bool IsPerfectSquare(int num) {
        
        if(num==1)
            return true;
        long r=num;
        long l=1;
        long mid=0;

        while(l<=r)
        {
            mid=(l+r)/2;

            if((mid*mid)==num)
                return true;

            else if((mid*mid)<num)
                l=mid+1;
            else
                r=mid-1;
        }
        return false;
    }
}
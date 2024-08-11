/* The isBadVersion API is defined in the parent class VersionControl.
      bool IsBadVersion(int version); */

public class Solution : VersionControl {
    public int FirstBadVersion(int n) {
        if(n==1)
            return n;
        int l=1;
        int r=n;
        int b=0;
        while(l<=r)
        {
           int mid=l+(r-l)/2;

            if(IsBadVersion(mid))
            {
                b=mid;
                r=mid-1;
            }
            else
            {
                l=mid+1;
            }    
        }
        return b;
    }
}
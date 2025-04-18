public class Solution {
    public int Trap(int[] height) 
    {
        if(height.Length==0 || height.Length==1)
            return 0;

        int l=0;
        int r=height.Length-1;

        int leftMax=height[0];
        int rightMax=height[height.Length-1];

        int sum=0;

        while(l<r)
        {
            if(leftMax<rightMax)
            {
                l=l+1;
                leftMax=Math.Max(leftMax,height[l]);
                sum=sum+(leftMax-height[l]);
            }
            else
            {
                r=r-1;
                rightMax=Math.Max(rightMax,height[r]);
                sum=sum+(rightMax-height[r]);
            }

        }
        return sum;

    }
    
    }
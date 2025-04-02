public class Solution {
    public int MaxArea(int[] height) {
        int maxArea=0;

        if(height.Length==0 || height.Length==1)
            return maxArea;
        
        int i=0;
        int j=height.Length-1;
        int area=0;

        while(i<j)
        {
            area= Math.Min(height[i],height[j])*(j-i);

            if(area>maxArea)
                maxArea=area;
            
            if(height[i]<height[j])
                i++;
            else
                j--;
        }

        return maxArea;
    }
}
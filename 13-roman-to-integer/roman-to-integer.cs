public class Solution {
    public int RomanToInt(string s) {
        char[] a=s.ToCharArray();
        int sum=0;
        int l=a.Length;
        
        for(int i=0;i<l;i++)
        {
           
            if(a[i]=='I')
            {
                if(i+1!=l)
                {
                    if(a[i+1]=='V')
                    {
                        sum=sum+4;
                        i++;
                        continue;
                    }
                
                    else if(a[i+1]=='X')
                    {
                        sum=sum+9;
                        i++;
                        continue;
                    }
                }
                sum=sum+1;
            }
            else if(a[i]=='X')
            {
                if(i+1!=l)
                {
                    if(a[i+1]=='L')
                    {
                        sum=sum+40;
                        i++;
                        continue;
                    }
                
                    else if(a[i+1]=='C')
                    {
                        sum=sum+90;
                        i++;
                        continue;
                    }
                }
                sum=sum+10;
            }
            else if(a[i]=='C')
            {
                if(i+1!=l)
                {
                    if(a[i+1]=='D')
                    {
                        sum=sum+400;
                        i++;
                        continue;
                    }
                
                    else if(a[i+1]=='M')
                    {
                        sum=sum+900;
                        i++;
                        continue;
                    }
                }
                sum=sum+100;
            }
            else if(a[i]=='V')
            {
                sum=sum+5;
            }
            else if(a[i]=='L')
            {
                sum=sum+50;
            }
            else if(a[i]=='D')
            {
                sum=sum+500;
            }
            else
            {
                sum=sum+1000;
            }
        }
        return sum;
    }
}
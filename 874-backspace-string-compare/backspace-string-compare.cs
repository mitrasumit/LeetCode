public class Solution {
    public bool BackspaceCompare(string s, string t) {
        
        int p1=s.Length-1;
        int p2=t.Length-1;

        while(p1>=0 || p2>=0)
        {
            if(p1>=0 && s[p1]=='#' || p2>=0 && t[p2]=='#')
            {
                if(p1>=0 && s[p1]=='#')
                {
                    int backSpace=2;
                    while(backSpace>0)
                    {
                        p1--;
                        backSpace--;

                        if(p1>=0 && s[p1]=='#')
                        {
                            backSpace=backSpace+2;
                        }
                        
                    }
                }

                if(p2>=0 && t[p2]=='#')
                {
                    int backSpace=2;
                    while(backSpace>0)
                    {
                        p2--;
                        backSpace--;

                        if(p2>=0 && t[p2]=='#')
                        {
                            backSpace=backSpace+2;
                        }
                        
                    }
                }
            }

            if (p1 >= 0 && p2 >= 0)
{
    if (s[p1] != t[p2])
    {
        return false;
    }
}
else if (p1 >= 0 || p2 >= 0)
{
    return false;
}
            
            p1--;
            p2--;

        }

        return true;
    }
}
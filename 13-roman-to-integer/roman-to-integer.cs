public class Solution {
    public int RomanToInt(string s) {
        int sum=0;
        Dictionary<char,int> v=new() 
        {
            {'I',1},
            {'V',5},
            {'X',10},
            {'L',50},
            {'C',100},
            {'D',500},
            {'M',1000}
        };
        for(int i=0;i<s.Length;i++)
        {
            char c=s[i];
            v.TryGetValue(c, out int num);
            if(i+1<s.Length && v[s[i+1]]>v[s[i]])
            sum=sum-num;
            else
            sum=sum+num;         
        }
        return sum;
    }
}
public class Solution {
    public bool IsValid(string s) {
        if(s.Length%2!=0)
            return false;
        else
        {
            Stack<char> st=new Stack<char>();
            Dictionary<char,char> map=new Dictionary<char,char>
            {
                {')','('},
                {'}','{'},
                {']','['},
            };

            foreach(char c in s)
            {
                if(map.ContainsKey(c))
                {
                    char te=st.Count>0 ? st.Pop() : 'n';
                    if(map[c]!=te)
                        return false;
                }
                else
                {
                    st.Push(c);
                }
            }
            return st.Count==0;
        }
        
    }
}
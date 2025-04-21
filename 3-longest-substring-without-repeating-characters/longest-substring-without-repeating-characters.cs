public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if (s.Length <= 1)
            return s.Length;

        Dictionary<char, int> seenChar = new Dictionary<char, int>();
        int longest = 0;
        int left = 0;

        for (int right = 0; right < s.Length; right++) {
            char currentChar = s[right];

            if (seenChar.TryGetValue(currentChar, out int prevSeen)) {
                if (prevSeen >= left) {
                    left = prevSeen + 1;
                }
            }

            seenChar[currentChar] = right;
            longest = Math.Max(longest, right - left + 1);
        }

        return longest;
    }
}

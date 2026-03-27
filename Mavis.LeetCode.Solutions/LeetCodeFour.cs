namespace Mavis.LeetCode.Solutions
{
    /// <summary>
    /// https://leetcode.com/problems/find-the-index-of-the-first-occurrence-in-a-string/description/
    /// </summary>
    public class LeetCodeFour
    {
        public int StrStr(string haystack, string needle) {
            var haystackAsSpan = haystack.AsSpan();
            var needleAsSpan = needle.AsSpan();
            
            if(needleAsSpan.Length > haystackAsSpan.Length)
            {
                return -1;
            }

            for (var haystackPosition = 0; haystackPosition < haystackAsSpan.Length; haystackPosition++) 
            {
                if(haystackPosition + needleAsSpan.Length > haystackAsSpan.Length)
                {
                    return -1;
                }
                else if(haystackAsSpan[haystackPosition] == needleAsSpan[0] && haystackAsSpan.Slice(haystackPosition, needleAsSpan.Length).SequenceEqual(needleAsSpan))
                {
                    return haystackPosition;
                }
            }

            return -1;
        }
    }
}

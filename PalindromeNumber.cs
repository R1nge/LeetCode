public class Solution {
    public bool IsPalindrome(int x) {
        var str = x.ToString();
        var arr = str.ToCharArray();
        Array.Reverse(arr);
        var str2 = new string(arr);
        if(str.Equals(str2))
        {
            return true;
        }
        return false;
    }
}
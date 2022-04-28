public class Solution {
    public bool IsPalindrome(int x) {
        var str = x.ToString();
        var arr = str.ToCharArray();
        Array.Reverse(arr);
        var str2 = new string(arr);
        return str.Equals(str2);
    }
}

public class Solution2 {
    public bool IsPalindrome(int x) {
        int num = x;
        int result = 0;
        int lastDigit = 0;
        while (num > 0)
        {
            lastDigit = num % 10;
            result = (result * 10) + lastDigit;    
            num = num / 10;
        }
        return x == result;
    }
}

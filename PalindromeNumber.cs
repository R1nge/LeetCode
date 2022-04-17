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
        
        if(x == result)
        {
            return true;
        }
        
        return false;
    }
}
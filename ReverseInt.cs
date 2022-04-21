public class Solution {
    public int Reverse(int x) {
        var reversed = MyReverse(x);    
        return reversed;
    }
    
    int MyReverse(int number){
        int result = 0;
        int left = number;
        while (Convert.ToBoolean(left)) 
        {
            int r = left % 10;
            if(result > Int32.MaxValue / 10) return 0;
            if(result < Int32.MinValue / 10) return 0;
            result = result*10 + r;
            left = left / 10;
        }
        
        return result;
    }
}

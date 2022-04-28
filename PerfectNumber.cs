//Very slow
public class Solution {
    public bool CheckPerfectNumber(int num) {
        int sum = 0;
        for (int i = 1; i < num; i++)
        {
            if(num % i == 0)
            {
                sum += i;
            }
        }
        if(sum == num)
        {
            return true;
        }
        return false;
    }
}
//Still pretty slow
public class Solution2 {
    public bool CheckPerfectNumber(int num) {
        int sum = 0;
        for (int i = 1; i <= num / 2; i++)
        {
            if(num % i == 0)
            {
                sum += i;
            }
        }
        if(sum == num)
        {
            return true;
        }
        return false;
    }
}

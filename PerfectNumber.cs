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
        return sum == num;
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
        return sum == num;
    }
}
//Very fast
public class Solution3 {
    public bool CheckPerfectNumber(int num) {
        if (num == 1)
           return false;
        int sum = 1;
        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if(num % i == 0)
            {
                 sum += i + num / i;
            }
        }
        return sum == num;
    }
}

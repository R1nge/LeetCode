public class Solution {
    public int TotalMoney(int n) {
        int total = 0;
        int monday = 1;
        int income = 0;
        for (int i = 0; i < n; i++)
        {
            if(i % 7 == 0 && i != 0)
            {
                monday += 1;
                income = monday;
            }
            else
            {
                income += 1;
            }
            total += income;
        }
        return total;
    }
}
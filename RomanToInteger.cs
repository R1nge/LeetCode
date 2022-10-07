public class Solution {
    public int RomanToInt(string s) {
        int result = 0;
        char previous = 'A';
        var dict = new Dictionary<char, int>
        {
            {'I', 1 },
            {'V', 5 },
            {'X', 10 },
            {'L', 50 },
            {'C', 100 },
            {'D', 500 },
            {'M', 1000 }
        };
        var length = s.Length - 1;
        for(int i = length; i >= 0; i--)
        {
            foreach(KeyValuePair<char, int> kvp in dict)
            {
                if(kvp.Key == s[i])
                {
                    if(previous == 'V' && kvp.Key == 'I')
                    {
                        result -= 5;
                        result += 4;
                    }
                    else if(previous == 'X' && kvp.Key == 'I')
                    {
                        result -= 10;
                        result += 9;
                    }
                    else if(previous == 'L' && kvp.Key == 'X')
                    {
                        result -= 50;
                        result += 40;
                    }
                    else if(previous == 'C' && kvp.Key == 'X')
                    {
                        result -= 100;
                        result += 90;
                    }
                    else if(previous == 'D' && kvp.Key == 'C')
                    {
                        result -= 500;
                        result += 400;
                    }
                    else if(previous == 'M' && kvp.Key == 'C')
                    {
                        result -= 1000;
                        result += 900;
                    }
                    else
                    {
                        result += kvp.Value;
                    }
                    
                    previous = kvp.Key;
                }
            }
        }
        
        return result;
    }
}

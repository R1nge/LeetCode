public class Solution {
    public IList<int> SelfDividingNumbers(int left, int right) {
        char[] charArray = new char[9999];
        List<int> list = new List<int>();
        int num = 0;
        while(left <= right)
        {
            charArray = left.ToString().ToCharArray();
            for(int i = 0; i < charArray.Length; i++)
            {
                num = (int)Char.GetNumericValue(charArray[i]);
                if(num != 0 && left % num == 0)
                {
                    if(i == charArray.Length - 1)
                    {
                        list.Add(left);
                    }
                }
                else
                {
                    break;
                }
            }
            left++;
        }
        return list;
    }
}

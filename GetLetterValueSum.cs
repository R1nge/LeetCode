using System;
class Solution 
{
  static void Main() 
  {
    var s = Solution("microspectrophotometries");
    Console.Write(s);
  }

  static int GetLetterValueSum(string s) 
  {
    var sum = 0;

    for (int i = 0; i < s.Length; i++) 
    {
      var num = Convert.ToChar(s[i]);
      sum += num - 96;
    }

    return sum;
  }
}

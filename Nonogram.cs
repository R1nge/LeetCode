using System;
using System.Collections.Generic;
class Solution
{
  static void Main ()
  {
    var s = Nonogram (new int[]{0,0,0,0,1,1,0,0,1,0,1,1,1});
    for(int i = 0; i < s.Count; i++)
    {
        Console.Write (s[i]);
    }
  }

  static List<int> Nonogram(int[] s)
  {
    var result = new List<int>();
    var streak = 0;
    
    for (int i = 0; i < s.Length; i++)
    {
        if((int) s[i] == 1)
        {
            streak++;
            if(i == s.Length - 1)
            {
                result.Add(streak);
            }
        }
        else
        {
            if(streak != 0)
            {
                result.Add(streak);
                streak = 0;
            }
            
        }
    } 
    
    return result;
  }
}

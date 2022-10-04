using System;
using System.Collections.Generic;
class Solution
{
  static void Main ()
  {
    var s = MakingChange(0);
    Console.Write (s);
  }

  static int MakingChange(int value)
  {
      var numberOfCoins = 0;
      var coins = new int[]{500, 100, 25, 10, 5, 1};
      
      for (int i = 0; i < coins.Length; i++)
      {
        while(value >= coins[i])
        {
            numberOfCoins++;
            value -= coins[i];
        }    
      }
      
      return numberOfCoins;
  }
}

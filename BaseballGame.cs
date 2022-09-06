public class Solution {
    public int CalPoints(string[] ops) {        
        List<int> list = new List<int>();
        int result = 0;
        
        for(int i = 0; i < ops.Length; i++)
        {
            if(ops[i].Equals("+"))
            {
                var first = Convert.ToInt32(list[list.Count - 1]); //BUG
                var second = Convert.ToInt32(list[list.Count - 2]);
                list.Add(first + second);
            }
            else if (ops[i].Equals("D"))
            {
                list.Add(Convert.ToInt32(list[list.Count - 1]) * 2);
            }
            else if(ops[i].Equals("C"))
            {
                list.RemoveAt(list.Count - 1);    
            }
            else
            {
                list.Add(Convert.ToInt32(ops[i]));    
            }
        }
        
        foreach(var item in list)
        {
            result += item;
        }
        
        return result;
    }
}

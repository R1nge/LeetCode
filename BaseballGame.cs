public class Solution {
    public int CalPoints(string[] ops) {        
        List<int> list = new List<int>();
        int result = 0;
        
        for(int i = 0; i < ops.Length; i++)
        {
            switch (ops[i])
            {
                case "+":
                    var first = Convert.ToInt32(list[list.Count - 1]); //BUG
                    var second = Convert.ToInt32(list[list.Count - 2]);
                    list.Add(first + second);
                    break;
                case "D":
                    list.Add(Convert.ToInt32(list[list.Count - 1]) * 2);
                    break;
                case "C":
                    list.RemoveAt(list.Count - 1);    
                    break;
                default:
                    list.Add(Convert.ToInt32(ops[i]));    
                    break;
            }
        }
        
        foreach(var item in list)
        {
            result += item;
        }
        
        return result;
    }
}

public class Solution2 {
    public int CalPoints(string[] ops) {        
        Stack<int> stack = new Stack<int>();
        int result = 0;
        
        for(int i = 0; i < ops.Length; i++)
        {
            switch (ops[i])
            {
                case "+":
                    var first = Convert.ToInt32(stack.Peek());
                    stack.Pop();
                    var second = Convert.ToInt32(stack.Peek());
                    stack.Push(first);
                    stack.Push(first + second);
                    break;
                case "D":
                    stack.Push(Convert.ToInt32(stack.Peek()) * 2);
                    break;
                case "C":
                    stack.Pop();    
                    break;
                default:
                    stack.Push(Convert.ToInt32(ops[i]));    
                    break;
            }
        }
        
        foreach(var item in stack)
        {
            result += item;
        }
        
        return result;
    }
}

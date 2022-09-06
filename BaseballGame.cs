public class Solution {
    public int CalPoints(string[] ops) {        
        List<int> list = new List<int>();
        int result = 0;
        
        for(int i = 0; i < ops.Length; i++)
        {
            int len = list.Count;
            switch (ops[i])
            {
                case "C":
                    var first = Convert.ToInt32(list[len - 1]);
                    var second = Convert.ToInt32(list[len - 2]);
                    list.Add(first + second);
                    break;
                case "D":
                    list.Add(Convert.ToInt32(list[len - 1]) * 2);
                    break;
                case "+":
                    list.RemoveAt(len - 1);    
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

public class Solution {
    public int CalPoints(string[] ops) {        
        Stack<int> stack = new Stack<int>();
        int result = 0;
        
        for(int i = 0; i < ops.Length; i++)
        {
            switch (ops[i])
            {
                case "C":
                    stack.Pop();    
                    break;
                case "D":
                    stack.Push(Convert.ToInt32(stack.Peek()) * 2);
                    break;
                case "+":
                    var first = Convert.ToInt32(stack.Pop());
                    var second = Convert.ToInt32(stack.Peek());
                    stack.Push(first);
                    stack.Push(first + second);
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

public class Solution {
    public bool IsValid(string s) {
        var stack = new Stack<char>();
         
        foreach (var bracket in s)
        {
             if (bracket.Equals('}') || bracket.Equals(')') || bracket.Equals(']'))
             {
                 if(!stack.TryPop(out var result))
                     return false;
                 
                 if (bracket.Equals('}') && result.Equals('{') ||
                    bracket.Equals(']') && result.Equals('[') ||
                    bracket.Equals(')') && result.Equals('(')) 
                    continue;
                 return false;
             }
             stack.Push(bracket);
         }
         return stack.Count == 0;
    }
}

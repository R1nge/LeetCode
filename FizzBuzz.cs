public class Solution {
    public IList<string> FizzBuzz(int n) {
        var list = new List<string>();
        for(int i = 1; i < n + 1; i++)
        {
            if(i % 3 == 0 && i % 5 == 0)
            {
                list.Add("FizzBuzz");
            }
            else if(i %  3 == 0)
            {
                list.Add("Fizz");
            }
            else if(i % 5 == 0)
            {
                list.Add("Buzz");
            }
            else
            {
                list.Add(i.ToString());
            }
        }
        return list;
    }
}

public class Solution2 {
    public IList<string> FizzBuzz(int n) {
        string[] answers = new string[n];
        for(int i = 0; i < n; i++)
        {
            if((i + 1) % 3 == 0 && (i + 1) % 5 == 0)
            {
                 answers[i] =  "FizzBuzz";
            }
            else if((i + 1) %  3 == 0)
            {
                 answers[i] = "Fizz";
            }
            else if((i + 1) % 5 == 0)
            {
                answers[i] = "Buzz";
            }
            else
            {
                answers[i] = (i + 1).ToString();
            }
        }
        return answers;
    }
}
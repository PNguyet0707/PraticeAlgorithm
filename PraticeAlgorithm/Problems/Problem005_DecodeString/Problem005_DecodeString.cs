using System.Text;

public class Problem005_DecodeString
{
    public string Solve(string s)
    {
        var current = new StringBuilder();
        var resultStack = new List<StringBuilder>();
        var countStack = new List<int>();
        int count = 0;

        foreach (var c in s)
        {
            if (char.IsDigit(c))
            {
                count = count * 10 + (c - '0');
            }
            else if (c == '[')
            {
                resultStack.Add(current);
                countStack.Add(count);
                current = new StringBuilder();
                count = 0;
            }
            else if (c == ']')
            {
                var last = resultStack[^1];
                resultStack.RemoveAt(resultStack.Count - 1);

                int repeat = countStack[^1];
                countStack.RemoveAt(countStack.Count - 1);

                for (int k = 0; k < repeat; k++)
                    last.Append(current);

                current = last;
            }
            else
            {
                current.Append(c);
            }
        }

        return current.ToString();
    }
}

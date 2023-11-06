class Program
{
    public static bool IsCorrect(string input)
    {
        Stack<char> check = new Stack<char>();
        foreach (char ch in input)
        {
            if (ch == '(' || ch == '{' || ch == '['|| ch == '<' )
            {
                check.Push(ch);
            }
            if (ch == ')' || ch == '}' || ch == ']'|| ch == '>' )
            {
                if (check.Count == 0)
                {
                    return false;
                }

                char poppedChar = check.Pop();

                if ((poppedChar == '(' && ch == ')') ||
                    (poppedChar == '{' && ch == '}') ||
                    (poppedChar == '[' && ch == ']') ||
                    (poppedChar == '<' && ch == '>'))
                {
                 continue;   
                }
                else
                {
                    return false;
                }
            }
        }
        return check.Count == 0;
    }
    static void Main(string[] args)
    {
        string input = "({x-y-z}*[x+2y]-(z+4x));";
        int processedChars;
        
        bool isCorrect = IsCorrect(input);

        Console.WriteLine($"Is the string correct: {isCorrect}");
        
    }
}
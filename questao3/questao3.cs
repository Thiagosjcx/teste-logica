namespace Questao3;

public static class ParentesesValidos
{
    public static bool Resolver(string s)
    {
        var pares = new Dictionary<char, char>
        {
            { ')', '(' },
            { ']', '[' },
            { '}', '{' }
        };
        var pilha = new Stack<char>();

        foreach (char c in s)
        {
            if (c == '(' || c == '[' || c == '{')
            {
                pilha.Push(c);
            }
            else if (c == ')' || c == ']' || c == '}')
            {
                if (pilha.Count == 0 || pilha.Pop() != pares[c])
                    return false;
            }
        }

        return pilha.Count == 0;
    }
}
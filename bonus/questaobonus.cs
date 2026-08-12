using System.Linq;

namespace QuestaoBonus;

public static class Palindromo
{
    // Limpa a string (só letras/números, minúsculo) e compara
    // com a versão invertida.
    // Complexidade: O(n) de tempo, O(n) de espaço.
    public static bool Resolver(string texto)
    {
        string limpo = new string(texto.Where(char.IsLetterOrDigit)
                                        .Select(char.ToLower)
                                        .ToArray());

        string invertido = new string(limpo.Reverse().ToArray());

        return limpo == invertido;
    }
}
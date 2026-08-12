using System.Collections.Generic;

namespace Questao5;

public static class ContagemCaracteres
{
    public static Dictionary<char, int> Resolver(string palavra)
    {
        var contagem = new Dictionary<char, int>();

        foreach (char letra in palavra)
        {
            if (contagem.ContainsKey(letra))
                contagem[letra]++;
            else
                contagem[letra] = 1;
        }

        return contagem;
    }
}
using System.Collections.Generic;

namespace Questao4;

public static class TwoSum
{
    public static int[]? ForcaBruta(int[] numeros, int target)
    {
        for (int i = 0; i < numeros.Length; i++)
        {
            for (int j = i + 1; j < numeros.Length; j++)
            {
                if (numeros[i] + numeros[j] == target)
                    return new[] { i, j };
            }
        }
        return null;
    }

    public static int[]? Otimizado(int[] numeros, int target)
    {
        var jaVistos = new Dictionary<int, int>(); 

        for (int i = 0; i < numeros.Length; i++)
        {
            int complemento = target - numeros[i];

            if (jaVistos.TryGetValue(complemento, out int indice))
                return new[] { indice, i };

            jaVistos[numeros[i]] = i;
        }

        return null;
    }
}
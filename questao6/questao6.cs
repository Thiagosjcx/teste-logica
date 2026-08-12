using System.Linq;

namespace Questao6;

public static class NumeroDesaparecido
{
    // Usa a soma de Gauss: soma esperada (0 até n) menos a soma real
    // do array = o número que falta. Sem ordenar, sem estrutura extra.
    // Complexidade: O(n) de tempo, O(1) de espaço extra.
    public static int Resolver(int[] numeros)
    {
        int n = numeros.Length; // array tem n elementos, mas vai de 0 a n
        int somaEsperada = n * (n + 1) / 2;
        int somaReal = numeros.Sum();
        return somaEsperada - somaReal;
    }
}
namespace Questao1;

public static class SomaPares
{
    public static int Resolver(int[] numeros)
    {
        int soma = 0;

        foreach (int numero in numeros)
        {
            bool eImpar = numero % 2 != 0;

            if (eImpar)
                continue;

            soma += numero;
        }

        return soma;
    }
}
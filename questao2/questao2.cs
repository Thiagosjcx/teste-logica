namespace Questao2;

public static class SegundoMaior
{
    public static int? Resolver(int[] numeros)
    {
        int? maior = null;
        int? segundoMaior = null;

        foreach (int numero in numeros)
        {
            if (maior == null || numero > maior)
            {
                if (numero != maior)
                    segundoMaior = maior;
                maior = numero;
            }
            else if (numero != maior && (segundoMaior == null || numero > segundoMaior))
            {
                segundoMaior = numero;
            }
        }

        return segundoMaior;
    }
}
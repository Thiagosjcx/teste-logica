using System;
using System.Linq;
using Questao4;

Console.WriteLine("Digite o target:");
int target = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Digite os números separados por espaço (ex: 2 7 11 15):");
int[] numeros = (Console.ReadLine() ?? "")
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

int[]? resultadoForcaBruta = TwoSum.ForcaBruta(numeros, target);
int[]? resultadoOtimizado = TwoSum.Otimizado(numeros, target);

Console.WriteLine(resultadoForcaBruta != null
    ? $"Força bruta -> índices: [{string.Join(", ", resultadoForcaBruta)}]"
    : "Força bruta -> nenhum par encontrado.");

Console.WriteLine(resultadoOtimizado != null
    ? $"Otimizado   -> índices: [{string.Join(", ", resultadoOtimizado)}]"
    : "Otimizado   -> nenhum par encontrado.");
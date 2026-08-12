using System;
using System.Linq;
using Questao6;

Console.WriteLine("Digite os números separados por espaço (ex: 3 0 1):");

int[] numeros = (Console.ReadLine() ?? "")
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

int resultado = NumeroDesaparecido.Resolver(numeros);

Console.WriteLine($"Número que falta: {resultado}");
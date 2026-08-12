using System;
using System.Linq;
using Questao1;

Console.WriteLine("Digite números separados por espaços");

string? entrada = Console.ReadLine();

int[] numeros = (entrada ?? "")
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

int resultado = SomaPares.Resolver(numeros);
Console.WriteLine($"A soma dos números pares é: {resultado}");
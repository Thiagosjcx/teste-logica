using System;
using System.Linq;
using Questao2;

Console.WriteLine("Digite números separados por espaços:");

string? entrada = Console.ReadLine();

int[] numeros = (entrada ?? "")
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

int? resultado = SegundoMaior.Resolver(numeros);

if (resultado == null)
    Console.WriteLine("Erro: não existe um segundo maior número distinto nesse array.");
else
    Console.WriteLine($"Segundo maior número: {resultado}");
using System;
using Questao5;

Console.WriteLine("Digite uma palavra (ex: banana):");

string palavra = Console.ReadLine() ?? "";

var resultado = ContagemCaracteres.Resolver(palavra);

foreach (var par in resultado)
    Console.WriteLine($"{par.Key}: {par.Value}");
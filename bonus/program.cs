using System;
using QuestaoBonus;

Console.WriteLine("Digite uma palavra ou frase (ex: Socorram me subi no onibus em Marrocos):");

string texto = Console.ReadLine() ?? "";

bool resultado = Palindromo.Resolver(texto);

Console.WriteLine($"É palíndromo: {resultado}");
using System;
using Questao3;

Console.WriteLine("Digite uma string com ( ) { } [ ] (ex: ([{}])):");

string entrada = Console.ReadLine() ?? "";

bool resultado = ParentesesValidos.Resolver(entrada);

Console.WriteLine($"Válido: {resultado}");
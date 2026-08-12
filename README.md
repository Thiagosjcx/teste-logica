Markdown
# Teste de Lógica — C# 🚀

Olá! Esse repositório guarda as minhas resoluções para o teste técnico de lógica de programação. Fiz todas as questões usando **C#** (Console Applications) rodando no **.NET**.

Tentei focar em deixar o código limpo, tratar casos estranhos (como arrays vazios ou sem o resultado esperado) e pensar um pouco na performance de cada solução.

---

## 📌 Sumário
1. [Como testar meu código](#1-como-testar-meu-código)
2. [Como organizei as pastas](#2-como-organizei-as-pastas)
3. [Resumo das Questões](#3-resumo-das-questões)
4. [Tecnologias](#4-tecnologias)

---

## 1. Como testar meu código

Para facilitar a vida de quem for corrigir, eu criei um script simples que funciona como um menu interativo. Assim você não precisa ficar entrando de pasta em pasta no terminal! 😄

**O jeito mais fácil:**
É só dar dois cliques no arquivo `menu.bat` que está na pasta principal, ou rodar ele direto no terminal:
```bash
.\menu.bat
Isso vai abrir um menu perguntando qual questão você quer rodar e ele já faz o trabalho de executar tudo.

O jeito manual (se preferir):
Caso queira rodar os projetos direto pelo CLI do .NET, é só entrar na pasta da questão e dar um run:

Bash
cd questao1
dotnet run
2. Como organizei as pastas
Deixei cada questão separada no seu próprio projeto para não misturar as coisas. A estrutura ficou assim:

Plaintext
📁 Teste-logica/
 ├── 📁 questao1/
 ├── 📁 questao2/
 ├── 📁 questao3/
 ├── 📁 questao4/
 ├── 📁 questao5/
 ├── 📁 questao6/
 ├── 📁 bonus/
 ├── 📄 menu.bat    <-- Script do menuzinho que eu criei
 └── 📄 README.md
3. Resumo das Questões
Aqui vai um resumão da estratégia que usei em cada desafio:

Questão 1 — Soma de pares: Pega um array de números e soma apenas os pares. Bem direto ao ponto.

Questão 2 — Segundo maior número: Acha o segundo maior número distinto de um array. Tomei o cuidado de tratar quando os números são repetidos ou quando não existe um segundo maior.

Questão 3 — Parênteses válidos: Verifica se uma string de parênteses, chaves e colchetes está abrindo e fechando na ordem certa (usei o conceito de Pilha/Stack aqui).

Questão 4 — Dois números (Two Sum): Acha a posição de dois números que somados dão o "target". Tentei otimizar a busca para não precisar usar dois loops um dentro do outro.

Questão 5 — Contagem de caracteres: Conta quantas vezes cada letra aparece numa string.

Questão 6 — Número desaparecido: Descobre qual número está faltando numa sequência de 0 até n.

Questão Bônus — Palíndromo: Verifica se a palavra ou frase pode ser lida de trás pra frente, ignorando os espaços e letras maiúsculas/minúsculas.

4. Tecnologias
C# / .NET

Batch Script (Apenas o arquivo .bat pra fazer o menu funcionar no Windows)

# Teste de Lógica — C# 🚀

Esse repositório tem as minhas resoluções do teste técnico de lógica de programação.  
Fiz todas as questões em **C#** (Console Application) no **.NET**.

Tentei deixar o código limpo, tratar os casos estranhos e pensar um pouco na performance de cada solução.

---

## 📌 Sumário

1. [Como testar meu código](#1-como-testar-meu-código)
2. [Como organizei as pastas](#2-como-organizei-as-pastas)
3. [Resumo das Questões](#3-resumo-das-questões)
4. [Tecnologias](#4-tecnologias)
5. [Observações](#5-observações)

---

## 1. Como testar meu código

Pra facilitar a vida de quem for corrigir, eu criei um script simples que funciona como um menu interativo. Assim você não precisa ficar entrando de pasta em pasta no terminal 😄

**O jeito mais fácil:**
É só dar dois cliques no arquivo `menu.bat` que está na pasta principal, ou rodar ele direto no terminal:

```bash
.\menu.bat
Ele abre um menu perguntando qual questão você quer rodar e já executa tudo.
O jeito manual (se preferir):
Caso queira rodar os projetos direto pelo CLI do .NET, é só entrar na pasta da questão e dar um run:
Bashcd questao1
dotnet run

2. Como organizei as pastas
Deixei cada questão separada no seu próprio projeto pra não misturar as coisas. A estrutura ficou assim:
text📁 Teste-logica/
 ├── 📁 questao1/          # Soma de pares
 ├── 📁 questao2/          # Segundo maior número
 ├── 📁 questao3/          # Parênteses válidos
 ├── 📁 questao4/          # Two Sum
 ├── 📁 questao5/          # Contagem de caracteres
 ├── 📁 questao6/          # Número desaparecido
 ├── 📁 bonus/             # Palíndromo
 ├── 📄 menu.bat           # Script do menuzinho
 └── 📄 README.md

3. Resumo das Questões
Questão 1 — Soma de pares
Pega os números e soma só os pares. Se só tiver ímpar, retorna 0.
Questão 2 — Segundo maior número
Acha o segundo maior número (sem repetir). Se não tiver segundo maior, mostra uma mensagem de erro.
Questão 3 — Parênteses válidos
Verifica se os parênteses (), {} e [] estão abrindo e fechando certinho (usei Stack).
Questão 4 — Two Sum
Acha a posição de dois números que somados dão o target (tentei fazer de um jeito mais otimizado).
Questão 5 — Contagem de caracteres
Conta quantas vezes cada letra aparece na string.
Questão 6 — Número desaparecido
Descobre qual número tá faltando na sequência de 0 até n (usei a fórmula de Gauss).
Questão Bônus — Palíndromo
Verifica se a palavra/frase pode ser lida de trás pra frente (ignorando espaços, pontuação e maiúscula/minúscula).

4. Tecnologias

C# / .NET
Batch Script (só o arquivo .bat pra fazer o menu funcionar no Windows)


5. Observações

Cada questão tá no seu próprio projeto
Tentei tratar os casos de borda
O menu.bat é só pra facilitar a correção no Windows

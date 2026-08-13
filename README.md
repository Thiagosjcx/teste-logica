Markdown
Este projeto foi desenvolvido para a resolução de um teste técnico focado em lógica de programação e algoritmos. O objetivo é demonstrar clareza de código, tratamento de casos extremos e organização.

---

## Tecnologias

* C# (.NET)
* Batch Script (.bat)

---

## Estrutura do Projeto

`/questao1` a `/questao6` Códigos isolados para cada desafio de lógica.  
`/bonus` Código separado para o desafio extra.  
`menu.bat` Arquivo executável para rodar o menu interativo no terminal.  

---

## Exercícios Resolvidos

* **Questão 1 — Soma de pares:** Soma todos os números pares de um array[cite: 1].
* **Questão 2 — Segundo maior número:** Encontra o segundo maior número distinto, tratando arrays com elementos repetidos[cite: 1].
* **Questão 3 — Parênteses válidos:** Verifica se parênteses, chaves e colchetes estão balanceados corretamente[cite: 1].
* **Questão 4 — Dois números (Two Sum):** Encontra a posição de dois números em um array cuja soma resulta no valor alvo (`target`)[cite: 1].
* **Questão 5 — Contagem de caracteres:** Conta quantas vezes cada caractere aparece em uma string[cite: 1].
* **Questão 6 — Número desaparecido:** Descobre qual número está faltando em uma sequência numérica de 0 a `n`[cite: 1].
* **Questão Bônus — Palíndromo:** Verifica se uma string pode ser lida da mesma forma de trás pra frente, ignorando espaços e maiúsculas/minúsculas[cite: 1].

---

## Como Começar

### Clone o repositório

```bash
git clone [https://github.com/seu-usuario/nome-do-repositorio.git](https://github.com/seu-usuario/nome-do-repositorio.git)
cd nome-do-repositorio
Execute o menu interativo
Para não precisar rodar pasta por pasta manualmente, criei um script de atalho. No terminal, basta rodar:

Bash
.\menu.bat
(Ou apenas dê dois cliques no arquivo menu.bat pelo Explorador de Arquivos do Windows).

Execução manual
Se preferir rodar os projetos de forma independente através do CLI do .NET:

Bash
cd questao1
dotnet run

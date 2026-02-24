# Calculadora de Equação do Segundo Grau - C# Windows Forms 

Este projeto é uma aplicação desktop desenvolvida em **C#**, que realiza o cálculo das raízes de uma equação do segundo grau utilizando a **Fórmula de Bhaskara**, além de gerar dinamicamente o **gráfico da função quadrática** em uma interface gráfica construída com **Windows Forms**.

O sistema permite visualizar tanto os valores numéricos das raízes quanto a representação visual da parábola correspondente à equação informada.

---

💡 **Como funciona**

O sistema realiza os seguintes processos:

1. **Inserção dos coeficientes:** O usuário informa os valores de `a`, `b` e `c` da equação do tipo `ax² + bx + c = 0`.

2. **Cálculo do Delta (Δ):** O programa calcula o discriminante utilizando a fórmula:

   Δ = b² - 4ac

3. **Cálculo das raízes:**
   - Se Δ > 0 → existem duas raízes reais e distintas.
   - Se Δ = 0 → existe uma raiz real (raiz dupla).
   - Se Δ < 0 → não existem raízes reais.

4. **Geração do gráfico:**
   - O sistema percorre um intervalo de valores de `x` utilizando um laço de repetição.
   - Para cada valor de `x`, calcula `y = ax² + bx + c`.
   - Os pontos são adicionados ao componente `Chart` do Windows Forms.
   - Quando existem raízes reais, elas são destacadas no eixo X.

---

🛠️ **Tecnologias Utilizadas**

* **Linguagem:** C#
* **Framework:** .NET (Windows Forms)
* **IDE:** Visual Studio

---

🖥️ **Como testar na sua máquina**

O projeto foi desenvolvido para execução local utilizando o Visual Studio. Siga os passos:

1. **Instale o Visual Studio:**
- Baixe e instale o [Visual Studio](https://visualstudio.microsoft.com/pt-br/) com a carga de trabalho **Desenvolvimento para desktop com .NET**.

2.  **Prepare os Arquivos:**
 - Clone ou baixe este repositório.

3. **Abra o projeto:**  
- Abra o Visual Studio.
- Clique em **Abrir um projeto ou solução**.
- Selecione o arquivo `.sln` do projeto.

4. **Execute a aplicação:**  
- Pressione `F5` ou clique em **Iniciar**.
- Insira os valores de `a`, `b` e `c`.
- Clique no botão de cálculo para visualizar as raízes e o gráfico da parábola.

> Experimente testar diferentes valores para os coeficientes. Observe como o gráfico se altera conforme o valor de `a` (concavidade da parábola) e como as raízes aparecem ou deixam de existir dependendo do valor do Delta.

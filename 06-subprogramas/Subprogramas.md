# 🚩 Desafio 06 - Subprogramas
Este desafio tem como proposta implementar funções que demonstrem passagem de parâmetros por valor e por referência em linguagens diferentes que domino (TypeScript e C#). 

## Formas de Passar Parâmetros

### 1. Passagem por Valor
Nesse tipo de passagem, o que é enviado para a função é uma cópia do valor da variável. Isso significa que qualquer alteração feita dentro da função não interfere na variável original fora dela.

### 2. Passagem por Referência
Neste caso, o que é enviado para a função é o endereço da variável original (ou uma referência a ela). Dessa forma, qualquer modificação feita dentro da função afeta diretamente a variável original usada fora da função

---

### C#: O Padrão é por Valor, com Opções para Referência
- Em C#, a regra geral é que os parâmetros são passados por valor. No entanto, o comportamento exato depende se o tipo do parâmetro é um tipo de valor (como int, double, bool, struct) ou um tipo de referência (como class, array, string). Para uma passagem explícita por referência, o C# oferece as palavras-chave ref e out.

- Passagem por Valor com Tipos de Valor
Quando um tipo de valor é passado para um método, uma cópia da variável é criada. Qualquer modificação feita no parâmetro dentro do método não afetará a variável original no escopo do chamador.

`Exemplo.cs`
```C#
using System;

public class Demonstracao
{
    public static void ModificarValor(int val) => val = 20;

    public static void ModificarReferencia(int[] arr) => arr[0] = 99;

    public static void ModificarComRef(ref int valRef) => valRef = 30;

    public static void InicializarComOut(out string strOut) => strOut = "Inicializado";

    public static void Main(string[] args)
    {
        int numero = 10;
        ModificarValor(numero);
        Console.WriteLine($"1. Por Valor (int): {numero}"); // Saída: 10

        int[] meuArray = { 5 };
        ModificarReferencia(meuArray);
        Console.WriteLine($"2. Por Valor (array): {meuArray[0]}"); // Saída: 99

        int numeroRef = 15;
        ModificarComRef(ref numeroRef);
        Console.WriteLine($"3. Por Referência (ref): {numeroRef}"); // Saída: 30

        InicializarComOut(out string texto);
        Console.WriteLine($"4. Por Referência (out): {texto}"); // Saída: Inicializado
    }
}
```
#### 1. Passagem Por Valor (com int)

- O método recebe uma cópia do valor (10). A alteração para 20 ocorre apenas na cópia, dentro do método.

- Resultado: A variável original permanece 10.

#### 2. Passagem Por Valor (com array)

- O método recebe uma cópia da referência (endereço) do array. Como a referência aponta para o mesmo objeto na memória, a alteração de seu conteúdo (arr[0] = 99) é refletida fora.

- Resultado: O conteúdo do array original é modificado para 99.

#### 3. Passagem Por Referência (com ref)

- A palavra-chave ref força a passagem da própria variável, e não de uma cópia.

- Resultado: Qualquer modificação dentro do método altera diretamente a variável original de 15 para 30.

#### 4. Passagem Por Referência (com out)

- Similar ao ref, mas com a intenção de inicializar uma variável que não tem valor.

- Resultado: O método recebe a referência e atribui o valor inicial à variável texto.


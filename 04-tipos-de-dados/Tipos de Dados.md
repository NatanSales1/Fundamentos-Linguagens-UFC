# 🚩 Desafio 04 - Tipos de Dados
Este desafio tem como proposta comparar a tipagem entre três linguagens de minha escolha **(Python, C e JavaScript)**, mostrando exemplos breves e comentados.

### C: Tipagem Estática e Fraca
Em C, a tipagem é estática, o que significa que o tipo de cada variável deve ser explicitamente declarado antes da compilação do código. O compilador verifica a consistência dos tipos em tempo de compilação, o que pode ajudar a capturar erros precocemente. No entanto, sua tipagem é considerada fraca devido à sua tendência a realizar conversões de tipo implícitas, o que pode levar a comportamentos inesperados se não for manuseado com cuidado.

**Exemplo:**
```C
#include <stdio.h>

int main() {
    int numero = 10;
    char letra = 'A'; // ASCII 65

    int resultado = numero + letra;

    printf("Número: %d\n", numero);
    printf("Resultado (10 + 'A'): %d\n", resultado); // Saída será 75 (10 + 65)

    return 0;
}
```
- **int numero;** fixa a variável numero para sempre conter valores inteiros.
- A operação numero + letra demonstra a tipagem fraca, onde o char letra é promovido a int para que a soma possa ocorrer sem um erro explícito.

### Python: Tipagem Dinâmica e Forte
Python apresenta uma abordagem de tipagem dinâmica. Isso significa que não é necessário declarar o tipo de uma variável; o tipo é determinado em tempo de execução, no momento da atribuição de um valor. A mesma variável pode, inclusive, referenciar objetos de tipos diferentes ao longo da execução do programa. Contudo, a tipagem de Python é forte, pois o interpretador não permite operações entre tipos incompatíveis sem uma conversão explícita, lançando uma exceção (TypeError).

### JavaScript: Tipagem Dinâmica e Fraca
Assim como Python, JavaScript possui tipagem dinâmica, onde os tipos de variáveis são resolvidos em tempo de execução e podem mudar. No entanto, sua característica mais marcante é a tipagem fraca, que leva à coerção de tipo automática. Isso significa que, ao realizar operações com tipos mistos, o JavaScript tentará converter os valores para um tipo compatível para que a operação possa ser executada, o que pode ser uma fonte de erros sutis.

# 🚩 Desafio 07 - Implementação de Subprogramas
Este desafio tem como proposta desenhar e explique o conceito de pilha de chamadas de um exemplo recursivo elaborado por mim (O exemplo abaixo foi feito na linguagem C).

## Pilha de chamadas (call stack)

A pilha de chamadas (call stack) é uma estrutura de dados que o programa utiliza para acompanhar as chamadas de funções. Quando uma função é chamada, um "quadro" (stack frame) é empilhado no topo, contendo informações sobre essa chamada (como parâmetros e variáveis locais). Quando a função retorna, seu quadro é desempilhado.

`main.c`
```C
#include <stdio.h>

/*
 * Soma de algarismos. Ex 1234 = 10
 * Quantidade de algarismos. Ex 1234 = 4
 * Produto dos algarismos. Ex 1234 = 24
*/

int somaAlgarismos(int numero) {
    if(numero < 10)
        return numero;
    else
        return numero % 10 + somaAlgarismos(numero / 10);
}

int quantAlgarismos(int numero) {
    if(numero < 10)
        return 1;
    else
        return quantAlgarismos(numero / 10) + 1;
}

int produtoAlgarismos(int numero) {
    if(numero < 10)
        return numero;
    else
        return numero % 10 * produtoAlgarismos(numero / 10);
}

int main()
{   printf("%d\n", somaAlgarismos(1234));
    printf("%d\n", quantAlgarismos(1234));
    printf("%d\n", produtoAlgarismos(1234));

    return 0;
}
```
Abaixo, o desenho representativo da função `somaAlgarismos`

> ![Call Stack](./Desenho_pilha.jpg)

### 1. somaAlgarismos

**Objetivo:** Somar os dígitos de um número. Ex: somaAlgarismos(1234) deve retornar 10 (pois 1 + 2 + 3 + 4 = 10).

**Lógica Simplificada:**

1. A função "arranca" o último dígito do número (1234 % 10 resulta em 4).
2. Ela então chama a si mesma com o restante do número (1234 / 10 resulta em 123).
3. Ela repete isso, guardando o dígito arrancado a cada passo, até que o número seja menor que 10.
4. Quando o número é menor que 10 (o ponto de parada), ela começa a somar os resultados de baixo para cima: 1 + 2 + 3 + 4.

### 2. quantAlgarismos

**Objetivo:** Contar a quantidade de dígitos. Ex: quantAlgarismos(1234) deve retornar 4.

**Lógica Simplificada:**

1. A função remove o último dígito (1234 / 10 resulta em 123).
2. Ela chama a si mesma com o número restante e adiciona 1 à contagem.
3. Ela repete isso até que o número seja menor que 10.
4. Quando o número é menor que 10 (o ponto de parada), a função retorna 1 (pois há um dígito).
5. No final, todos os + 1 são somados, resultando na contagem total.

### 3. produtoAlgarismos

**Objetivo:** Multiplicar os dígitos entre si. Ex: produtoAlgarismos(1234) deve retornar 24 (pois 1 * 2 * 3 * 4 = 24).

**Lógica Simplificada:**

1. "Arranca" o último dígito (4).
2. Chama a si mesma com o restante do número (123).
3. Ela repete isso até que o número seja menor que 10.
4. Quando atinge o ponto de parada (número < 10), começa a multiplicar os resultados de baixo para cima: 1 * 2 * 3 * 4.

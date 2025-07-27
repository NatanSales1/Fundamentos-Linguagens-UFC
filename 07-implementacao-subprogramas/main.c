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

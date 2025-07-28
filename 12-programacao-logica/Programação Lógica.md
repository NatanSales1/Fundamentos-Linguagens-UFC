# 🚩 Desafio 12 - Programação Lógica
Este desafio tem como proposta modelar um pequeno problema lógico (ex.: resolver um quebra-cabeça, genealogia) usando uma sintaxe inspirada em Prolog.

## O Cenário do Problema
Três amigos, Ana, Beto e Carla, foram a uma confeitaria. Cada um pediu uma sobremesa diferente: bolo, pudim ou sorvete. Eles também pediram bebidas diferentes: café, suco ou chá.

Temos as seguintes pistas para descobrir quem pediu o quê:

1. A pessoa que pediu café sentou-se ao lado de quem comeu bolo.\
2. Ana não comeu pudim.
3. Quem comeu sorvete também pediu chá.
4. Beto sentou-se à esquerda de Carla. (Para simplificar, vamos interpretar "ao lado de" como vizinhos em uma fila, e a ordem é Beto, Carla, e o terceiro amigo).

**Objetivo:** Descobrir a combinação de pessoa, sobremesa e bebida para cada um.

---

### Modelagem de Sintaxe Inspirada em Prolog
**Entidades:**

```Prolog
pessoa(ana).
pessoa(beto).
pessoa(carla).

sobremesa(bolo).
sobremesa(pudim).
sobremesa(sorvete).

bebida(cafe).
bebida(suco).
bebida(cha).
```

### Representação da Solução

O nosso objetivo é encontrar uma lista de "triplas", onde cada tripla contém pessoa(Nome), sobremesa(Prato), bebida(Drink). Vamos chamar essa estrutura de solucao.

Por exemplo, uma possível solução seria: [pessoa(ana, bolo, cafe), pessoa(beto, pudim, suco), pessoa(carla, sorvete, cha)].

### Traduzindo as pistas para Regras Lógicas
Transformamar cada pista em uma regra que a solução deve satisfazer. Em Prolog, :- significa "se", e a vírgula , significa "e".

```Prolog
% Regra para verificar se duas pessoas são vizinhas na solução.
vizinho(X, Y, Solucao) :- nextto(X, Y, Solucao).
vizinho(X, Y, Solucao) :- nextto(Y, X, Solucao).

% Regra Principal: encontrar_solucao(S)
encontrar_solucao(S) :-
    % S é uma lista com 3 triplas (pessoa, sobremesa, bebida).
    S = [ pedido(P1, Sobremesa1, Bebida1),
          pedido(P2, Sobremesa2, Bebida2),
          pedido(P3, Sobremesa3, Bebida3) ],

    % Garantiremos que todas as pessoas, bebidas e sobremesas são únicas.
    pessoa(P1), pessoa(P2), pessoa(P3),
    P1 \= P2, P1 \= P3, P2 \= P3,

    sobremesa(Sobremesa1), sobremesa(Sobremesa2), sobremesa(Sobremesa3),
    Sobremesa1 \= Sobremesa2, Sobremesa1 \= Sobremesa3, Sobremesa2 \= Sobremesa3,

    bebida(Bebida1), bebida(Bebida2), bebida(Bebida3),
    Bebida1 \= Bebida2, Bebida1 \= Bebida3, Bebida2 \= Bebida3,

    % 1. A pessoa que pediu café sentou-se ao lado de quem comeu bolo.
    vizinho(pedido(_, _, cafe), pedido(_, bolo, _), S),

    % 2. Ana não comeu pudim.
    member(pedido(ana, SobremesaAna, _), S),
    SobremesaAna \= pudim,

    % 3. Quem comeu sorvete também pediu chá.
    member(pedido(_, sorvete, cha), S),

    % 4. Beto sentou-se à esquerda de Carla.
    nextto(pedido(beto, _, _), pedido(carla, _, _), S).
```

### Solução
O sistema chegaria à seguinte conclusão:

```Prolog
Solucao = [
  pedido(beto, pudim, cafe),
  pedido(carla, bolo, suco),
  pedido(ana, sorvete, cha)
]
```

Finalizando, vamos verificar se a solução está de acordo com as pistas fornecidas no problema acima:

- Quem pediu café (Beto) sentou ao lado de quem comeu bolo (Carla)? Sim, eles são vizinhos na solução.
- Ana não comeu pudim? Sim, ela comeu sorvete.
- Quem comeu sorvete (Ana) pediu chá? Sim.
- Beto sentou-se à esquerda de Carla? Sim, ele vem antes dela na lista.

**Todas as condições satisfeitas.**


# 🚩 Desafio 11 - Programação Funcional
Este desafio tem como proposta implementar uma solução funcional com a propriedade da recursão e funções de alta ordem, a partir de um problema real ou fictício. O exemplo demonstrado será na linguagem TypeScript:

## O Cenário do Problema
Escolhi o tema futebolistico, onde o problema é calcular a quantidade de pontos de um time em um campeonato, no qual essa pontuação é definida por:

- Vitória - **3 pontos**
- Empate - **1 pontos**
- Derrota - **0 pontos**

O desafio é criar uma função que receba uma lista de resultados de partidas de um time específico e calcule a sua pontuação total ao final do campeonato.

---

### A Estrutura dos Dados
Para representar os resultados das partidas, definiremos uma estrutura de dados simples em TypeScript. Cada partida será um objeto com o número de gols marcados pelo time da casa e pelo time visitante.

```TypeScript
type ResultadoPartida = {
  golsMarcados: number;
  golsSofridos: number;
};
```

### 1. Lógica para a Pontuação
Primeiro, criamos uma função que recebe o resultado de uma partida e retorna a pontuação obtida.
```TypeScript
const calcularPontosPartida = (resultado: ResultadoPartida): number => {
  if (resultado.golsMarcados > resultado.golsSofridos) {
    return 3; // Vitória
  } else if (resultado.golsMarcados === resultado.golsSofridos) {
    return 1; // Empate
  } else {
    return 0; // Derrota
  }
};
```

### 2. A Função Recursiva Principal
Será por meio da função `calcularPontosTotais`
- **Caso Base:** Se a lista de partidas estiver vazia, a pontuação é 0.
- **Recursividade:** A função processa a primeira partida da lista, calcula seus pontos utilizando a função `calcularPontosPartida`, e então se chama recursivamente com o restante da lista, somando o resultado atual com o resultado das chamadas subsequentes:
  
```TypeScript
const calcularPontosTotais = (
  partidas: ResultadoPartida[],
  calculadorDePontos: (resultado: ResultadoPartida) => number
): number => {
  if (partidas.length === 0) {
    return 0;
  }

  const [primeiraPartida, ...restoDasPartidas] = partidas;
  const pontosDaPartida = calculadorDePontos(primeiraPartida);

  return pontosDaPartida + calcularPontosTotais(restoDasPartidas, calculadorDePontos);
};
```
### Simulando resultados
`Brasileirao.ts`
```TypeScript
const resultadosDoTime: ResultadoPartida[] = [
  { golsMarcados: 2, golsSofridos: 1 }, 
  { golsMarcados: 1, golsSofridos: 0 }, 
  { golsMarcados: 0, golsSofridos: 3 }, 
  { golsMarcados: 3, golsSofridos: 0 }, 
  { golsMarcados: 2, golsSofridos: 2 }, 
];

const pontuacaoFinal = calcularPontosTotais(resultadosDoTime, calcularPontosPartida);

console.log(`A pontuação final do time é: ${pontuacaoFinal} pontos.`);

// Saída: A pontuação final do time é: 10 pontos.
```





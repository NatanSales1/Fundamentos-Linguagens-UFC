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

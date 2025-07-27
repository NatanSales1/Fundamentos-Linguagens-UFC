
function demonstracaoPorValor(valor: number): void {
  valor = valor * 2;
  console.log(`   -> Dentro da função (primitivo): ${valor}`);
}

interface Pessoa {
  nome: string;
}

function demonstracaoPorValorComObjeto(pessoa: Pessoa): void {
  pessoa.nome = "Maria"; 
  pessoa = { nome: "João" }; 
  console.log(`   -> Dentro da função (objeto): Nome alterado para 'Maria', tentativa de reatribuir para 'João'`);
}

interface ValorWrapper {
    valor: number;
}

function simularPassagemPorReferencia(wrapper: ValorWrapper): void {
    wrapper.valor = wrapper.valor * 2;
    console.log(`   -> Dentro da função (wrapper): ${wrapper.valor}`);
}

console.log("--- 1. Demonstração de Passagem por VALOR (com tipo primitivo) ---");
let numeroPrimitivo: number = 10;
console.log(`Antes da chamada: ${numeroPrimitivo}`);
demonstracaoPorValor(numeroPrimitivo);
console.log(`Depois da chamada: ${numeroPrimitivo} (inalterado)\n`);


console.log("--- 2. Demonstração de Passagem por VALOR (com tipo de objeto) ---");
let pessoaOriginal: Pessoa = { nome: "Ana" };
console.log(`Antes da chamada: ${pessoaOriginal.nome}`);
demonstracaoPorValorComObjeto(pessoaOriginal);
console.log(`Depois da chamada: ${pessoaOriginal.nome} (propriedade alterada, mas não o objeto)\n`);


console.log("--- 3. Simulação de Passagem por REFERÊNCIA (usando um objeto wrapper) ---");
let numeroWrapper: ValorWrapper = { valor: 15 };
console.log(`Antes da chamada: ${numeroWrapper.valor}`);
simularPassagemPorReferencia(numeroWrapper);
console.log(`Depois da chamada: ${numeroWrapper.valor} (alterado)`);

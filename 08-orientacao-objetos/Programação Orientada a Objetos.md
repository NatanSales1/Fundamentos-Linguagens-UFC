# 🚩 Desafio 08 - Programação Orientada a Objetos
Este desafio tem como proposta modelar uma hierarquia simples de classes em um domínio de minha preferência (ex.: personagens, transportes, serviços). O domínio escolhido foi o segmento de automóveis.

Este exemplo demonstra conceitos fundamentais de Programação Orientada a Objetos (POO) como **Herança, Abstração, Encapsulamento e Polimorfismo.**

## Estrutura da Hierarquia

- `Veiculo` (Classe Abstrata): A classe base que contém atributos e comportamentos comuns a todos os veículos. Será abstrata porque não faz sentido criar um "veículo genérico", mas sim tipos específicos de veículos.
- `Carro` (Classe Concreta): Herda de Veiculo e adiciona características específicas de um carro, como o número de portas.
- `Motocicleta` (Classe Concreta): Também herda de Veiculo e adiciona características de uma motocicleta, como as cilindradas.
- `Main` (Classe Concreta): Também herda de Veiculo e adiciona características de uma motocicleta, como as cilindradas.

---

### 1. Classe Abstrata `Veiculo`
- Define a base para todos os veículos, com atributos e comportamentos comuns.

```Java
public class Carro extends Veiculo {
    private int numeroDePortas;

    public Carro(String marca, String modelo, int ano, int portas) {
        super(marca, modelo, ano); // Chama o construtor da superclasse
        this.numeroDePortas = portas;
    }

    @Override
    public void ligar() {
        System.out.println("Carro ligado.");
    }
}
```

### 2. Subclasse `Carro`
- Herda de `Veiculo` e adiciona características de um carro.

```Java
public class Carro extends Veiculo {

    private int numeroDePortas;

    public Carro(String marca, String modelo, int ano, int numeroDePortas) {
        // Chama o construtor da classe pai (Veiculo)
        super(marca, modelo, ano);
        this.numeroDePortas = numeroDePortas;
    }

    @Override
    public void ligar() {
        System.out.println("O carro " + modelo + " foi ligado.");
    }
    
    public int getNumeroDePortas() {
        return numeroDePortas;
    }

    @Override
    public String toString() {
        return "Carro [marca=" + marca + ", modelo=" + modelo + ", ano=" + ano + ", portas=" + numeroDePortas + ", velocidadeAtual=" + velocidadeAtual + " km/h]";
    }
}
```

### 3. Subclasse `Motocicleta`
- Também herda de `Veiculo` com suas próprias especificidades.

```Java
public class Motocicleta extends Veiculo {
    private int cilindradas;

    public Motocicleta(String marca, String modelo, int ano, int cilindradas) {
        super(marca, modelo, ano);
        this.cilindradas = cilindradas;
    }

    @Override
    public void ligar() {
        System.out.println("Motocicleta ligada. Vrum vrum!");
    }
}
```

### Criando instâncias demonstrando o funcionamento:
```Java
public class Main {
    public static void main(String[] args) {
        Carro meuCarro = new Carro("Ford", "Mustang", 2023, 2);
        Motocicleta minhaMoto = new Motocicleta("Honda", "CB 500F", 2022, 500);

        meuCarro.ligar();     
        minhaMoto.ligar();  

        meuCarro.acelerar(120);
        minhaMoto.acelerar(90);

        System.out.println(meuCarro);  
        System.out.println(minhaMoto);  
    }
}
```

---

### Conceitos Demonstrados:
- **Herança:** Carro e Motocicleta reutilizam a estrutura de Veiculo.
- **Abstração:** Veiculo é uma classe abstract que define um "contrato" (o método ligar()).
- **Polimorfismo:** ligar() tem um comportamento diferente para Carro e Motocicleta.
- **Encapsulamento:** Os dados são contidos dentro de cada classe.

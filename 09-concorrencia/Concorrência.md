# 🚩 Desafio 09 - Concorrência
Este desafio tem como proposta explicar a diferença entre threads e processos e implementar um exemplo que demonstre essa diferênça. O exemplo implementado é na linguagem C#

---

## O que é uma Thread?

Uma thread (ou "linha de execução") é a menor unidade de execução dentro de um processo. Um processo pode ter uma ou várias threads. Se um processo é um programa em execução, as threads são as diferentes tarefas que esse programa executa "ao mesmo tempo".

### Características principais de uma thread:

- **Dependência:** As threads existem dentro de um processo e não são independentes.
- **Memória Compartilhada:** Todas as threads de um mesmo processo compartilham o mesmo espaço de memória. Elas podem acessar as mesmas variáveis globais e dados, o que facilita a comunicação entre elas.
- **Recursos Compartilhados:** Threads compartilham os recursos do processo pai (arquivos, conexões, etc.).
- **Custo de Criação Baixo:** Criar uma nova thread é muito mais rápido e leve do que criar um novo processo, pois não é necessário alocar um novo bloco de memória.
- **Exemplo:** Em um editor de texto (o processo), uma thread pode ser responsável por receber o que você digita, outra por verificar a ortografia em tempo real e uma terceira por salvar o documento automaticamente em segundo plano. Todas essas tarefas ocorrem dentro do mesmo programa e compartilham o acesso ao mesmo documento.

## O que é um Processo?

Um processo é uma instância de um programa em execução. Quando você abre um aplicativo (como o seu navegador de internet, um editor de texto ou um jogo), o sistema operacional cria um processo para ele.

### Características principais de um processo:

- **Independência:** Cada processo é executado de forma independente e isolada dos outros.
- **Espaço de Memória Próprio:** Cada processo possui seu próprio espaço de memória virtual. Isso significa que um processo não pode acessar diretamente a memória de outro. Se o processo A travar, ele não afeta diretamente o processo B.
- **Recursos Próprios:** O sistema operacional aloca recursos (como arquivos abertos, conexões de rede e tempo de CPU) de forma individual para cada processo.
- **Custo de Criação Elevado:** Criar um novo processo é uma operação "pesada" e lenta para o sistema operacional, pois exige a alocação de um novo espaço de memória e de todas as estruturas de dados associadas.
- **Exemplo:** Cada aba aberta no seu Google Chrome, ou cada aplicativo diferente aberto no seu computador (Spotify, Word, etc.), geralmente é executado como um processo separado.

### Implementação de Exemplo: Thread x Processo

`Exemplo.cs`
```C#
using System;
using System.Diagnostics;
using System.Threading;

class Program
{
    private static int _contadorCompartilhado = 0;

    static void Main(string[] args)
    {
        Console.WriteLine("### DEMONSTRAÇÃO DE THREADS (MEMÓRIA COMPARTILHADA) ###");
        DemonstrarThreads();

        Console.WriteLine("\n--------------------------------------------------\n");

        Console.WriteLine("### DEMONSTRAÇÃO DE PROCESSOS (MEMÓRIA ISOLADA) ###");
        DemonstrarProcessos();
    }

    // Threads 
    public static void DemonstrarThreads()
    {
        Console.WriteLine($"Valor inicial do contador: {_contadorCompartilhado}");

        var threads = new List<Thread>();

        for (int i = 1; i <= 3; i++)
        {

            Thread novaThread = new Thread(TrabalhoDaThread);
            novaThread.Name = $"Thread {i}"; 
            threads.Add(novaThread);
            novaThread.Start(); 
        }

        foreach (var thread in threads)
        {
            thread.Join();
        }

        Console.WriteLine($"\nTodas as threads terminaram.");
        Console.WriteLine($"Valor FINAL do contador: {_contadorCompartilhado}");
        Console.WriteLine("=> Observe como todas as threads modificaram A MESMA variável.");
    }

    public static void TrabalhoDaThread()
    {
        for (int i = 0; i < 5; i++)
        {
            _contadorCompartilhado++;
            Console.WriteLine($"{Thread.CurrentThread.Name} incrementou o contador para: {_contadorCompartilhado}");
            Thread.Sleep(150); 
        }
    }


    // Processos 
    public static void DemonstrarProcessos()
    {
        Console.WriteLine("Iniciando um novo processo: 'notepad.exe' (Bloco de Notas)...");
        try
        {
            Process? novoProcesso = Process.Start("notepad.exe");

            if (novoProcesso != null)
            {
                Console.WriteLine($"Processo do Bloco de Notas iniciado com sucesso!");
                Console.WriteLine($"ID do Processo: {novoProcesso.Id}");
                Console.WriteLine("=> Nosso programa NÃO PODE acessar ou modificar a memória interna do Bloco de Notas.");
                Console.WriteLine("   Ele é um 'restaurante' totalmente separado.");

                Console.WriteLine("\nPor favor, feche o Bloco de Notas para continuar...");
                novoProcesso.WaitForExit();
                
                Console.WriteLine("O processo do Bloco de Notas foi fechado.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao iniciar o processo: {ex.Message}");
        }
    }
}
```

- **Threads:** Agiram como "cozinheiros no mesmo restaurante", todos acessando e modificando o mesmo _contadorCompartilhado (o "estoque de ingredientes").
- **Processo:** O Bloco de Notas agiu como "outro restaurante". Nosso programa conseguiu abri-lo e saber quando ele fechou, mas não teve como entrar na sua "cozinha" (memória) para interagir com suas variáveis internas.

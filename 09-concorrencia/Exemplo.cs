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

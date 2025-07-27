using System;

public class Demonstracao
{
    public static void ModificarValor(int val) => val = 20;

    public static void ModificarReferencia(int[] arr) => arr[0] = 99;

    public static void ModificarComRef(ref int valRef) => valRef = 30;

    public static void InicializarComOut(out string strOut) => strOut = "Inicializado";

    public static void Main(string[] args)
    {
        int numero = 10;
        ModificarValor(numero);
        Console.WriteLine($"1. Por Valor (int): {numero}"); // Saída: 10

        int[] meuArray = { 5 };
        ModificarReferencia(meuArray);
        Console.WriteLine($"2. Por Valor (array): {meuArray[0]}"); // Saída: 99

        int numeroRef = 15;
        ModificarComRef(ref numeroRef);
        Console.WriteLine($"3. Por Referência (ref): {numeroRef}"); // Saída: 30

        InicializarComOut(out string texto);
        Console.WriteLine($"4. Por Referência (out): {texto}"); // Saída: Inicializado
    }
}

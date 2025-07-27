


```C#
using System;
using System.Threading;

class AssistenteAcademicoAI
{
    static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("=============================================");
        Console.WriteLine("===   Assistente Acadêmico AI - Ativado   ===");
        Console.WriteLine("=============================================");
        Console.ResetColor();
        Console.WriteLine("\nOlá! Sou seu assistente digital.");
        Console.WriteLine("Descreva sua tarefa e eu recomendarei a melhor ferramenta de IA para você.");

        while (true)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nDigite uma palavra-chave para sua tarefa (ex: escrever, imagem, código, cálculo) ou 'sair' para encerrar:");
            Console.ResetColor();
            
            string entradaUsuario = Console.ReadLine().ToLower().Trim();

            if (entradaUsuario == "sair")
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\nEntendido. Encerrando o Assistente Acadêmico. Bons estudos!");
                Console.ResetColor();
                break; 
            }

            Console.WriteLine("Analisando sua necessidade...");
            Thread.Sleep(700);

            switch (entradaUsuario)
            {
                case "escrever":
                case "texto":
                case "redação":
                case "resumo":
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\n[RECOMENDAÇÃO]: Para tarefas de escrita, como ensaios, resumos ou geração de texto, use um Modelo de Linguagem Grande (LLM).");
                    Console.WriteLine("-> Ferramentas como Gemini, ChatGPT ou Claude são excelentes para isso.");
                    Console.ResetColor();
                    break;

                case "imagem":
                case "desenho":
                case "arte":
                case "foto":
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\n[RECOMENDAÇÃO]: Para criar imagens, artes ou ilustrações a partir de texto, use um Modelo de Difusão.");
                    Console.WriteLine("-> Ferramentas como Midjourney, DALL-E 3 ou Stable Diffusion são ideais para essa tarefa.");
                    Console.ResetColor();
                    break;

                case "código":
                case "programação":
                case "programar":
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\n[RECOMENDAÇÃO]: Para gerar, completar ou depurar código, use uma IA especializada em programação.");
                    Console.WriteLine("-> Ferramentas como o GitHub Copilot ou assistentes integrados em LLMs (Gemini, ChatGPT) são muito eficazes.");
                    Console.ResetColor();
                    break;

                case "cálculo":
                case "matemática":
                case "conta":
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\n[RECOMENDAÇÃO]: Para resolver problemas matemáticos complexos ou realizar cálculos simbólicos, use um Solucionador Matemático baseado em IA.");
                    Console.WriteLine("-> Ferramentas como o WolframAlpha ou a capacidade de análise avançada de dados do Gemini são as mais indicadas.");
                    Console.ResetColor();
                    break;

                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n[ERRO]: Não reconheci essa tarefa. Por favor, tente usar uma das palavras-chave sugeridas.");
                    Console.ResetColor();
                    continue; 
            }
        }
    }
}
```

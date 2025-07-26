# 🚩 Desafio 03 - Descrições Sintáticas e Semânticas
Este desafio tem como proposta criar uma mini-gramática fictícia para uma linguagem de minha autoria com exemplos de análise léxica.

## Etapas de processamento
**Análise Léxica:** Nesta fase inicial, o código-fonte bruto é lido e fatiado em seus componentes mais básicos, os "tokens". Pense nisso como desmontar uma frase em suas palavras e sinais de pontuação individuais.

**Análise Sintática:** Organiza os tokens em uma hierarquia, geralmente uma "árvore de sintaxe", para garantir que o código esteja formatado corretamente, da mesma forma que uma oração precisa de um sujeito e um verbo na ordem certa para ser válida.

**Análise Semântica:** Depois de confirmar que a "gramática" do código está correta, esta análise verifica se o código faz sentido lógico. Ela investiga o significado por trás da estrutura, procurando por erros de coerência. É aqui que o sistema garante que você só use variáveis que já foram criadas e que não tente realizar operações impossíveis, como multiplicar um texto por um número.

**Parsing:** É o processo de transformar dados brutos (geralmente texto) em uma estrutura de dados mais organizada, como uma árvore sintática ou um objeto Python, que pode ser mais facilmente processado por um computador.

## Compilador
- Em poucas palavras, traduz o código-fonte fornecido pelo usuário em alguma linguagem de alto nível para uma versão de código baixo nível, que é a versão do código que o computador/processador pode ler e executar.
- **GCC (GNU Compiler Collection),** é o compilador das linguagens **C/C++**


## Interpretador
- Software que age como um "tradutor simultâneo" para o código-fonte. Em vez de converter o programa inteiro para a linguagem da máquina de uma só vez, ele lê e executa cada instrução passo a passo, de forma sequencial. Dessa forma, a tradução de uma linha de código acontece no exato momento em que ela precisa ser executada, em um processo contínuo de leitura e ação.
- **Python, JavaScript, PHP e Ruby** são exemplos.

## Máquina Virtual
- Uma Máquina Virtual (VM) de Aplicação é um ambiente de software que funciona como um "computador intermediário". Ela cria uma camada de abstração que permite a um programa rodar de forma idêntica em qualquer plataforma, independentemente do hardware ou do sistema operacional real.
- **VirtualBox** é um exemplo.

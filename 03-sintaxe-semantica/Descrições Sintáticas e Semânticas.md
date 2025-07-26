# 🚩 Desafio 03 - Descrições Sintáticas e Semânticas
Este desafio tem como proposta criar uma mini-gramática fictícia para uma linguagem de minha autoria com exemplos de análise léxica.

## 1. Objetivo da Linguagem (Optic)
Ser uma linguagem de programação didática, simples e legível, voltada para iniciantes ou fins educacionais, onde o foco é ler e mostrar valores, tomar decisões simples, e manipular dados básicos (texto e número).

## 2. Lexemas e Tokens
| Categoria           | Exemplos                 | Token                    |
| ------------------- | ------------------------ | ------------------------ |
| Palavra-chave       | `VAR`, `SE`, `FAZ`, ...  | `PALAVRA_CHAVE`          |
| Identificador       | `cpf`, `sexo`          | `IDENTIFICADOR`          |
| Número literal      | `26`, `1050`             | `LITERAL_NUMERO`         |
| Texto literal       | `"Olá"`                   | `LITERAL_TEXTO`          |
| Atribuição          | `<-`                     | `SETA_ATRIBUICAO`        |
| Relacional          | `=`, `>`, `<`            | `OPERADOR_RELACIONAL`    |
| Aritmético          | `+`, `-`                 | `OPERADOR_ARITMETICO`    |
| Pontuação           | `:`                      | `DOIS_PONTOS`            |
| Comentários (extra) | `# O que está aqui é ignorado` | Ignorado pelo analisador |


## Estrutura BNF
```bnf
<programa>     ::= <comando>+

<comando>      ::= <declaracao> | <atribuicao> | <io> | <decisao>

<declaracao>   ::= VAR <identificador> : <tipo>
<tipo>         ::= NUMERO | TEXTO

<atribuicao>   ::= <identificador> <- <expressao>

<io>           ::= MOSTRAR <expressao> | LER <identificador>

<decisao>      ::= SE <condicao> FAZ <comando>+ FIM_SE

<condicao>     ::= <expressao> <operador_relacional> <expressao>
<operador_relacional> ::= "=" | "<" | ">"

<expressao>    ::= <termo> ( <operador_aritmetico> <termo> )?
<termo>        ::= <identificador> | <numero_literal> | <texto_literal>
```


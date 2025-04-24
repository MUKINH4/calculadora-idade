# 📅 Calculadora de Idade

Uma aplicação de console desenvolvida em **C#** que calcula a idade do usuário com base na data de nascimento e verifica se é maior de idade para obtenção da CNH.

## 🔸 INTEGRANTES

Samuel Heitor - RM 556731
Renato David - RM 555627
Lucas Nicolini - RIM 55/613
Gustavo Lopes - RM 556859
Gabriel Jablonski - RM 555452
Matheus Munuera - RM 557812

## 🔹 Recursos

* Cálculo preciso de idade considerando mês e dia
* Verificação de maioridade (18 anos)
* Validação de entrada de dados
* Interface simples via console

## 🔹 Instalação e Execução

1. Obtenha o código fonte:

```
git clone https://github.com/seu-usuario/calculadora-idade.git
```

2. Abra o projeto no ambiente de desenvolvimento
3. Compile e execute a aplicação

## 🔹 Como Funciona

A calculadora implementa a seguinte lógica:

* **Estrutura de Dados**: 
  Utiliza uma `struct Pessoa` que armazena nome e data de nascimento

* **Validação de Entradas**:
  - Nome: aceita apenas letras e espaços
  - Data: verifica o formato correto (DD/MM/AAAA)

* **Cálculo de Idade**:
  - Subtrai o ano de nascimento do ano atual
  - Ajusta o valor caso o aniversário ainda não tenha ocorrido no ano atual
  - Implementado no método `CalcularIdade()`

* **Verificação de Maioridade**:
  - Método `MaiorDeIdade()` verifica se a pessoa tem 18 anos ou mais
  - Exibe mensagem sobre a possibilidade de obter CNH

## 🔹 Tecnologias

* Linguagem C#
* .NET Framework
* Aplicação Console
* Programação estruturada com uso de `struct`

## 🔹 Exemplo de Uso

```
Calculadora de idade
Digite seu nome: João Silva
Digite sua data de nascimento (DD/MM/AAAA): 15/03/2000
Olá João Silva, você tem 25 anos.
Você é maior de idade e pode tirar a CNH.
```

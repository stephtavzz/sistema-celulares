# 📱 Sistema de Celulares em C#

![C#](https://img.shields.io/badge/C%23-10.0%2B-purple)
![.NET](https://img.shields.io/badge/.NET-8.0-blue)

## 📌 Sobre o Projeto

Este projeto foi desenvolvido como parte de um desafio prático da **DIO (Digital Innovation One)** no módulo de **Programação Orientada a Objetos** da trilha **.NET**.  
O objetivo é implementar um **sistema orientado a objetos** que simule o comportamento de celulares, com foco em abstração, herança e polimorfismo.

## ⚙️ Funcionalidades Implementadas

1. **Classe abstrata `Smartphone`**
   - Contém propriedades básicas como `Número`, `Modelo`, `IMEI` e `Memória`;
   - Define métodos comuns como `Ligar`, `ReceberLigacao` e o método abstrato `InstalarAplicativo`.

2. **Classes derivadas `Nokia` e `Iphone`**
   - Ambas herdam de `Smartphone`;
   - Cada uma implementa sua própria lógica para o método `InstalarAplicativo`, simulando o comportamento específico de cada marca.

3. **Testes no `Program.cs`**
   - Instancia de objetos `Nokia` e `Iphone`;
   - Demonstra chamadas de métodos como `Ligar`, `ReceberLigacao` e `InstalarAplicativo`;
   - Exibe a saída formatada no console, simulando o uso de dois smartphones diferentes.

## 🖥️ Exemplo de Uso

Ao executar o programa, o seguinte resultado será exibido no console:


## 🖥️ Exemplo de Uso

Smartphone Nokia:
Ligando...
Instalando o aplicativo "Whatsapp" no Nokia

Smartphone iPhone:
Recebendo ligação...
Instalando o aplicativo "Telegram" no iPhone.


## ✅ Regras de Negócio

- A classe `Smartphone` é **abstrata**, não podendo ser instanciada diretamente;
- As classes `Nokia` e `Iphone` devem **obrigatoriamente sobrescrever** o método `InstalarAplicativo`;
- Cada marca tem sua **própria implementação**, promovendo reuso de código e respeitando os princípios de OOP.

## 🛠️ Tecnologias Utilizadas

- C# 10+
- .NET 8.0
- **Visual Studio Code** como ambiente de desenvolvimento

## 📂 Como Executar o Projeto

1. Clone o repositório:
```bash
git clone https://github.com/stephtavzz/sistema-celulares.git
```

2. Navegue até o diretório do projeto:
```bash
cd sistema-celulares
```

3. Execute o projeto:
```bash
dotnet run
```
## 👩‍💻 Autora

**Stephanie Tavares dos Santos**  
🔗 [LinkedIn](https://www.linkedin.com/in/stephanie-t-santos/)  
💻 [GitHub](https://github.com/stephtavzz)  


Este projeto foi desenvolvido para fins educacionais, como parte de um desafio da plataforma DIO, visando a prática de sintaxe básica com C# e .NET.

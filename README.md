# Exercícios de Programação Orientada a Objetos (POO)

Este repositório contém os exercícios realizados na disciplina **Programação Orientada a Objetos I** do curso **Análise e Desenvolvimento de Sistemas** da **Universidade Paulista (UNIP)**, **Campus de Araçatuba**, turma **DS3P14**. A disciplina aborda os conceitos fundamentais de **POO** utilizando a linguagem **C#**.

## Exercícios

### **Exercício 1: Classe `Carro`**

Crie uma classe `Carro` com os seguintes atributos:
- `Marca`
- `Modelo`
- `Ano`

O construtor da classe deve receber esses valores e um método `ExibirInformacoes` deve ser responsável por exibir as informações do carro no console.

**Objetivo**: Instanciar um objeto e exibir suas informações.

### **Exercício 2: Herança com a classe `Funcionario`**

Crie uma classe `Funcionario` com os atributos:
- `Nome`
- `SalarioBase`

Em seguida, crie uma classe `Gerente` que herda de `Funcionario` e adiciona um atributo adicional `Bonus`. Implemente um método que exiba o salário total do gerente (salário base + bônus).

**Objetivo**: Demonstrar o uso de herança e criação de classes especializadas.

### **Exercício 3: Classe Abstrata `Veiculo`**

Crie uma classe abstrata `Veiculo` que contenha um método abstrato `Acelerar()`. Depois, crie duas classes, `Carro` e `Moto`, ambas herdando de `Veiculo`, e implemente o método `Acelerar()` com mensagens personalizadas para cada tipo de veículo.

**Objetivo**: Demonstrar o uso de classes abstratas e métodos abstratos.

### **Exercício 4: Polimorfismo com `Funcionario`**

Crie uma classe base `Funcionario` com um método `CalcularBonus()`. Em seguida, crie duas classes, `Desenvolvedor` e `Gerente`, que herdam de `Funcionario`, cada uma com um cálculo diferente para o bônus. Instancie objetos das duas classes e use polimorfismo para calcular o bônus de cada tipo de funcionário.

**Objetivo**: Aplicar o conceito de polimorfismo e sobrecarga de métodos.

### **Exercício 5: Sistema de Vendas**

**Desafio**: Agora que aprendemos os conceitos de classes, herança, abstração e polimorfismo, vamos estruturar um pequeno sistema de vendas.

#### **Descrição do Sistema**

- **Classe `Cliente`**: Representa um cliente, com os atributos `Nome` e `ID`.
- **Classe `Pedido`**: Contém os produtos comprados e o cliente que realizou a compra.
- **Classe `Venda`**: Gerencia os pedidos e pode gerar um recibo no final.

**Objetivo**: Estruturar a classe e seus componentes de forma que o sistema seja capaz de registrar pedidos e gerar recibos.

## Tecnologias Utilizadas

- **Linguagem**: C#
- **Visual Studio Code 2022**
- **Paradigma**: Programação Orientada a Objetos (POO)

## Como Executar os Exercícios

1. Clone o repositório:
   ```bash
   git clone https://github.com/SEU-USUARIO/POO-UNIP-DS3P14.git

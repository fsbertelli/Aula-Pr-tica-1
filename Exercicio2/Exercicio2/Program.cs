using System;
class Funcionario // Classe Funcionario
{
    public string Nome = ""; // Atributo Nome
    public float SalarioBase = 0; // Atributo SalarioBase

    public Funcionario(string nome, float SalarioBase) // Construtor da classe Funcionario
    {
        this.Nome = nome; // Atribui o valor de nome ao atributo Nome
        this.SalarioBase = SalarioBase; // Atribui o valor de SalarioBase ao atributo SalarioBase
    }
}
class Gerente : Funcionario // Classe Gerente herda de Funcionario
{
    public Gerente(string nome, float SalarioBase) : base(nome, SalarioBase) { } // Construtor da classe Gerente
    public void calculaSalario(float bonus) // Método calculaSalario
    {
        Console.WriteLine($"O gerente {Nome} " +
            $"recebe o salário base R$:{SalarioBase} " +
            $"e bonus R${bonus} " +
            $"totalizando: R${SalarioBase + bonus}"); // Exibe o salário total do gerente
    }
}
class Program // Classe Principal
{
    static void Main() // Método Principal
    {
        Gerente func = new Gerente("Felipe", 1000);  // Instancia um objeto func da classe Gerente com atributos Nome e SalarioBase
        func.calculaSalario(150); // Chama o método calculaSalario com o parâmetro bônus 150
    }
}
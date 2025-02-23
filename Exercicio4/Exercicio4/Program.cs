class Funcionario // Declaração da classe Funcionario
{
    public virtual float CalcularBonus(float SalarioBase, float Bonus) // Método virtual que calcula o bônus do funcionário
    {
        return SalarioBase * Bonus; // Retorna o salário base multiplicado pelo bônus
    }
}
class Desenvolvedor : Funcionario // Declaração da classe Desenvolvedor que herda a classe Funcionario
{
    public override float CalcularBonus(float SalarioBase, float Bonus) // Método que sobrescreve o método CalcularBonus da classe Funcionario
    {
        return SalarioBase * (Bonus * 1.15f + Bonus); // Retorna o salário base multiplicado pelo bônus e mais o bônus
    }
}
class Gerente : Funcionario // Declaração da classe Gerente que herda a classe Funcionario
{
    public override float CalcularBonus(float SalarioBase, float Bonus) // Método que sobrescreve o método CalcularBonus da classe Funcionario
    {
        return SalarioBase * (Bonus * (1.75f/2) + Bonus); // Retorna o salário base multiplicado pelo bônus e mais o bônus
    }
}
class Program // Declaração da classe principal Program
{
    static void Main() // Método principal Main
    {
        Desenvolvedor dev = new Desenvolvedor(); // Instância do objeto dev da classe Desenvolvedor
        Console.WriteLine($"Salario anual do Desenvolvedor: R${dev.CalcularBonus(1000, 100)}"); // Exibe o salário anual do Desenvolvedor por meio do método herdado da classe Funcionario
        Console.WriteLine($"Salario mensal do Desenvolvedor: R${(dev.CalcularBonus(1000, 100)/12)}"); // Exibe o salário mensal do Desenvolvedor por meio do método herdado da classe Funcionario

        Gerente manager = new Gerente(); // Instância do objeto manager da classe Gerente
        Console.WriteLine($"Salario anual do Gerente: R${manager.CalcularBonus(2000, 100)}"); // Exibe o salário anual do Gerente por meio do método herdado da classe Funcionario
        Console.WriteLine($"Salario mensal do Gerente: R${(manager.CalcularBonus(2000, 100))/12}"); // Exibe o salário mensal do Gerente por meio do método herdado da classe Funcionario
    }
}
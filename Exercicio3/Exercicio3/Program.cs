abstract class Veiculo //Declaração da classe abstrata Veiculo
{
    public abstract string Acelerar(); //Declaração do método abstrato Acelerar
}
class Carro : Veiculo //Declaração da classe Carro herdando Veiculo
{
    public override string Acelerar() //Implementação do método Acelerar sobrescrevendo o método abstrato da classe Veiculo
    {
        return "O carro está acelerando";  //Retorna a mensagem personalizada para a classe Carro
    }
}
class Moto : Veiculo //Declaração da classe Moto herdando Veiculo
{ 
    public override string Acelerar() //Implementação do método Acelerar sobrescrevendo o método abstrato da classe Veiculo
    {
        return "A moto está acelerando"; //Retorna a mensagem personalizada para a classe Moto
    }
}
class Program //Declaração da classe principal Program
{
    static void Main() //Método principal Main
    {
        Carro carro = new Carro(); //Instância do objeto carro da classe Carro
        Console.WriteLine(carro.Acelerar()); //Exibe a mensagem personalizada da classe Carro herdada de Veiculo
        Moto moto = new Moto(); //Instância do objeto moto da classe Moto
        Console.WriteLine(moto.Acelerar()); //Exibe a mensagem personalizada da classe Moto herdada de Veiculo
    }
}
using System;
class Carro // classe Carro
{
    public string marca; // define atributo marca
    public string modelo; // define atributo modelo
    public int ano; // define atributo ano

    public Carro(string marca, string modelo, int ano) // instancia o construtor da classe Carro
    {
        this.marca = marca; // atribui o valor de marca ao atributo marca
        this.modelo = modelo; // atribui o valor de modelo ao atributo modelo
        this.ano = ano; // atribui o valor de ano ao atributo ano
    }
    public void ExibirInformacoes() // método que exibe as informações do carro
    {
        Console.WriteLine($"Marca: {marca} - Modelo: {modelo} - Ano: {ano}"); // exibe as informações do carro
    }
}
class Program // classe principal
{
    static void Main() 
    {
        Carro carro = new Carro("Volkswagen", "Fusca", 1972); // instancia um objeto carro da classe Carro
        carro.ExibirInformacoes(); // chama o método ExibirInformacoes a partir do objeto carro da classe Carro
    }
}
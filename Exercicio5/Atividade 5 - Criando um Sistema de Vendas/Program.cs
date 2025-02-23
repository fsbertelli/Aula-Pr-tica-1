using System;
class Venda //Instanciando a classe Venda
{
    Pedido pedido { get; set; } //Atributo pedido do tipo Pedido
    Cliente cliente { get; set; } //Atributo cliente do tipo Cliente
    public Venda(Pedido pedido, Cliente cliente) //Construtor da classe Venda usando os atributos pedido e cliente das classes Pedido e Cliente como parâmetros
    {
        this.pedido = pedido; //Atribuindo o valor de pedido ao atributo pedido
        this.cliente = cliente; //Atribuindo o valor de cliente ao atributo cliente
    }
    public string GerarVenda() //Método GerarVenda
    {
        return $"\t\t\t\tVenda realizada com sucesso!\n\n" +
            $"\t\t\tCliente: {cliente.nomeCliente}\n" +
            $"\t\t\tProduto: {pedido.nomeProduto}\n" +
            $"\t\t\tPreço: R$ {pedido.precoProduto}\n" +
            $"\t\t\tQuantidade: {pedido.qtyProduto}\n" +
            $"\t\t\t--------------\n" +
            $"\t\t\tTotal: R$ {pedido.precoProduto * pedido.qtyProduto}\n"; //Retorna a mensagem de venda realizada com sucesso
    }
}
class Cliente
{ //Instanciando a classe Cliente
    public int id; //Atributo ID
    public string nomeCliente; //Atributo nomeCliente
    public Cliente(int id, string nomeCliente) //Construtor da classe Cliente
    { 
        this.id = id; //Atribuindo o valor de id ao atributo id
        this.nomeCliente = nomeCliente; //Atribuindo o valor de nomeCliente ao atributo nomeCliente
    }
    public virtual string GerarRelatorio()  //Método GerarRelatorio
    {
        return $"\n\t\t\t\tCliente Cadastrado com sucesso!\n\n\t\t\t ID: {id} - Nome: {nomeCliente}\n\n\t\t\t==========================================\n"; //Retorna a mensagem de sucesso
    }
}
class Pedido : Cliente //Instanciando a classe Pedido herdando da classe Cliente
{
    public string nomeProduto = ""; //Atributo nomeProduto
    public float precoProduto; //Atributo precoProduto
    public int qtyProduto; //Atributo qtyProduto
    Cliente cliente { get; set; } //Atributo cliente do tipo Cliente

    public Pedido(string nomeProduto, float precoProduto, int qtyProduto, Cliente cliente) : base(cliente.id, cliente.nomeCliente) //Construtor da classe Pedido
    {
        {
            this.nomeProduto = nomeProduto; //Atribuindo o valor de nomeProduto ao atributo nomeProduto
            this.precoProduto = precoProduto; //Atribuindo o valor de precoProduto ao atributo precoProduto
            this.qtyProduto = qtyProduto; //Atribuindo o valor de qtyProduto ao atributo qtyProduto
            this.cliente = cliente; //Atribuindo o valor de cliente ao atributo cliente
        }
    }
    public override string GerarRelatorio() //Método GerarRelatorio herdado da classe Cliente
    {
        return $"\t\t\t\tPedido realizado com sucesso!\n\n" +
            $"\t\t\tQuantidade: {qtyProduto}" +
            $" - {nomeProduto}" +
            $" - R$ {precoProduto} un " +
            $"- Total: R${qtyProduto*precoProduto}" +
            $"\n\n\t\t\t==========================================\n"; //Retorna a mensagem de sucesso
    }
}
class Program //Instanciando a classe principal Program
{
    static void Main() //Método Main
    {
        Cliente customer = new Cliente(1, "Felipe"); //Instanciando o objeto customer da classe Cliente
        Console.WriteLine(customer.GerarRelatorio());//Imprimindo o relatório do cliente cadastrado a partir do método herdado GerarRelatorio
        Pedido cart = new Pedido("Produto XPTO", 10, 5, customer); //Instanciando o objeto cart da classe Pedido passando o objeto customer como parâmetro
        Console.WriteLine(cart.GerarRelatorio());  //Imprimindo o relatório do pedido realizado a partir do método herdado GerarRelatorio
        Venda sell = new Venda(cart, customer); //Instanciando o objeto sell da classe Venda passando os objetos cart e customer como parâmetros
        Console.WriteLine(sell.GerarVenda()); //Imprimindo a mensagem de venda realizada com sucesso a partir do método herdado GerarVenda
    }
}
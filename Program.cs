using System;

class Program
{
    static void Main()
    {
        Produto produto1 = new Produto { ID = 1, Nome = "Produto 1", Preco = 10.99m, Descricao = "Descrição do Produto 1" };
        Produto produto2 = new Produto { ID = 2, Nome = "Produto 2", Preco = 15.99m, Descricao = "Descrição do Produto 2" };

        CarrinhoDeCompras carrinho = new CarrinhoDeCompras();
        carrinho.AdicionarItem(produto1);
        carrinho.AdicionarItem(produto2);

        Pedido pedido = new Pedido
        {
            NumeroPedido = 1,
            Carrinho = carrinho,
            NomeCliente = "Fulano",
            EnderecoEntrega = "Rua Exemplo, 123"
        };

        Console.WriteLine("Detalhes do Pedido:");
        Console.WriteLine($"Número do Pedido: {pedido.NumeroPedido}");
        Console.WriteLine($"Nome do Cliente: {pedido.NomeCliente}");
        Console.WriteLine($"Endereço de Entrega: {pedido.EnderecoEntrega}");
        Console.WriteLine("Itens do Carrinho:");
        foreach (var item in carrinho.Itens)
        {
            Console.WriteLine($"{item.Nome} - {item.Preco:C}");
        }
        Console.WriteLine($"Total do Pedido: {pedido.CalcularTotal():C}");
    }
}

public class Pedido
{
    public int NumeroPedido { get; set; }
    public CarrinhoDeCompras Carrinho { get; set; }
    public string NomeCliente { get; set; }
    public string EnderecoEntrega { get; set; }

    public decimal CalcularTotal()
    {
        return Carrinho.CalcularTotal();
    }
}

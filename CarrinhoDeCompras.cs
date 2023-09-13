using System.Collections.Generic;

public class CarrinhoDeCompras
{
    public List<Produto> Itens { get; set; }

    public CarrinhoDeCompras()
    {
        Itens = new List<Produto>();
    }

    public void AdicionarItem(Produto produto)
    {
        Itens.Add(produto);
    }

    public void RemoverItem(Produto produto)
    {
        Itens.Remove(produto);
    }

    public decimal CalcularTotal()
    {
        decimal total = 0;
        foreach (var item in Itens)
        {
            total += item.Preco;
        }
        return total;
    }
}

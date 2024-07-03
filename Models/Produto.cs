public class Produto
{
    public int Id{get;set;}
    public string Nome{get;set;}
    public string Marca{get;set;}
    public decimal Preco{get;set;}
    public DateTime? Validade{get;set;}
}

public class ListaDeProdutos
{
    private List<Produto> produtos = new List<Produto>();

    public void AdicionarProduto(Produto produto)
    {
        produtos.Add(produto);
    }

    public List<Produto> ObterProdutos()
    {
        return produtos;
    }

    public Produto ObterProduto(int id)
    {
        return produtos[id];
    }

    public void AtualizarProduto(int id, Produto produtoAtualizado)
    {
        if (id >= 0 && id < produtos.Count)
        {
            produtos[id] = produtoAtualizado;
        }
    }

    public void RemoverProduto(int id)
    {
        if (id >= 0 && id < produtos.Count)
        {
            produtos.RemoveAt(id);
        }
    }
}
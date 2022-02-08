using GraphQL.API.Models;
using System.ComponentModel.DataAnnotations;

public class Produto
{
    [Key]
    public Guid Id { get; set; }
    public string Nome { get; set; }
    public string Categoria { get; set; }
    public decimal Valor { get; set; }
    public int Status { get; set; }
    public DateOnly DataCadastro { get; set; }
    public IList<Avaliacao> Avaliacoes { get; set; }

    public static IList<Produto> GerarListaDeProdutoAleatorio()
    {
        var p = new List<Produto>();
        var rnd = new Random();
       
        for (int x = 1; x <= 5; x++)
        {
            for (int i = 1; i <= 100; i++)
            {
                var id = Guid.NewGuid();
                var novoProduto = new Produto
                {
                    Id = id,
                    Nome = $"Produto {i}",
                    Categoria = $"Categora {x}",
                    Valor = rnd.Next(1, 150),
                    Status = 1,
                    DataCadastro = DateOnly.FromDateTime(DateTime.Now)
                };

                novoProduto.Avaliacoes = new List<Avaliacao>()
                { 
                    new Avaliacao { IdProduto = id, Produto = novoProduto, Nota = rnd.Next(1, 10) },
                    new Avaliacao { IdProduto = id, Produto = novoProduto, Nota = rnd.Next(1, 10) },
                    new Avaliacao { IdProduto = id, Produto = novoProduto, Nota = rnd.Next(1, 10) }
                };

                p.Add(novoProduto);
            }
        }

        return p;
    }
}


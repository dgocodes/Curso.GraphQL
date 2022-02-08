using System.ComponentModel.DataAnnotations;

public class Produto
{
    [Key]
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Categoria { get; set; }
    public decimal Valor { get; set; }
    public int Status { get; set; }
    public DateOnly DataCadastro { get; set; }

    public static IList<Produto> GerarListaDeProdutoAleatorio()
    {
        var p = new List<Produto>();
        var rnd = new Random();
        var id = 1;
        for (int x = 1; x <= 5; x++)
        {
            for (int i = 1; i <= 100; i++)
            {
                p.Add(new Produto
                {
                    Id = id++,
                    Nome = $"Produto {i}",
                    Categoria = $"Categora {x}",
                    Valor = rnd.Next(1, 150),
                    Status = 1,
                    DataCadastro = DateOnly.FromDateTime(DateTime.Now)
                });
            }
        }

        return p;
    }
}


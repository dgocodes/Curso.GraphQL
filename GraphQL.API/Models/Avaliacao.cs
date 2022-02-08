namespace GraphQL.API.Models
{
    public class Avaliacao
    {
        public int Nota { get; set; }

        public string? Comentario { get; set; }

        public Guid IdProduto { get; set; }

        public Produto Produto { get; set; }
    }
}

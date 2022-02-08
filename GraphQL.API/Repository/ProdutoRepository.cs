namespace GraphQL.API.Repository
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly IList<Produto> _produtos;

        public ProdutoRepository()
        {
            _produtos = Produto.GerarListaDeProdutoAleatorio();
        }

        public IList<Produto> GetAll() => 
            _produtos;        

        public Produto? GetById(int id) =>
             _produtos.FirstOrDefault(x => x.Id == id);
    }
}

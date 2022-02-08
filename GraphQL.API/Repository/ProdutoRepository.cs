namespace GraphQL.API.Repository
{
    public class ProdutoRepository : IProdutoRepository
    {
        private IList<Produto> _produtos;

        public ProdutoRepository()
        {
            _produtos = Produto.GerarListaDeProdutoAleatorio();
        }

        public Produto Add(Produto produto)
        {
            var maxId = _produtos.Max(o => o.Id);

            produto.Id = maxId + 1;
            produto.DataCadastro = DateOnly.FromDateTime(DateTime.Now);
            produto.Status = 1;

            _produtos.Add(produto);

            return produto;
        }

        public Produto? Update(int id, Produto produto)
        {
            var produtoUpdate = GetById(id);

            if (produtoUpdate != null)
            {
                produtoUpdate.Status = produto.Status;
                produtoUpdate.Categoria = produto.Categoria;
                produtoUpdate.Valor = produto.Valor;
                produtoUpdate.Nome = produto.Nome;
            }

            return produtoUpdate;
        }

        public IList<Produto> GetAll() =>
            _produtos;

        public Produto? GetById(int id) =>
             _produtos.FirstOrDefault(x => x.Id == id);

        public void Delete(int id)
        {
            var produto = GetById(id);

            if (produto != null)
                _produtos.Remove(produto);
        }
    }
}

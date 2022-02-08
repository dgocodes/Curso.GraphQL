namespace GraphQL.API.Repository
{
    public interface IProdutoRepository
    {
        IList<Produto> GetAll();

        Produto? GetById(int id);
    }
}
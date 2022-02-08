namespace GraphQL.API.Repository
{
    public interface IProdutoRepository
    {
        IList<Produto> GetAll();

        Produto? GetById(Guid id);

        Produto Add(Produto produto);

        Produto? Update(Guid id, Produto produto);

        void Delete(Guid id);
    }
}
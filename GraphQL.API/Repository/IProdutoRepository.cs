namespace GraphQL.API.Repository
{
    public interface IProdutoRepository
    {
        IList<Produto> GetAll();

        Produto? GetById(int id);

        Produto Add(Produto produto);

        Produto? Update(int id, Produto produto);

        void Delete(int id);
    }
}
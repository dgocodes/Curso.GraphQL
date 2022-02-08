using GraphQL.API.GraphQL.Types;
using GraphQL.API.Repository;
using GraphQL.Types;

namespace GraphQL.API.GraphQL.Queries
{
    public class ProdutoQuery : ObjectGraphType
    { 
        //Mapear o Get do repositorio
        public ProdutoQuery(IProdutoRepository produtoRepository)
        {
            Field<ListGraphType<ProdutoType>>("produtos",
                                              "Retorna uma lista de produtos",
                                              resolve: context => produtoRepository.GetAll());

            Field<ProdutoType>("produto",
                               "Retorna um curso por ID",
                               new QueryArguments(new QueryArgument<NonNullGraphType<IntGraphType>>
                               {
                                   Name = "id",
                                   Description = "Id do Produto"
                               }),
                               resolve: context => produtoRepository.GetById(context.GetArgument("id", int.MinValue)));
        }
    }
}

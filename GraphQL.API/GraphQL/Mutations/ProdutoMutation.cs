using GraphQL.API.GraphQL.Types;
using GraphQL.API.Repository;
using GraphQL.Types;

namespace GraphQL.API.GraphQL.Mutations
{
    public class ProdutoMutation : ObjectGraphType
    {
        public ProdutoMutation(IProdutoRepository produtoRepository)
        {
            Field<ProdutoType>("addProduto",
                               "Salva um produto na base de dados",
                               arguments: new QueryArguments(
                                   new QueryArgument<NonNullGraphType<ProdutoInputType>>
                                   {
                                       Name = "produto",
                                       Description = "Produto input parameter"
                                   }),
                               resolve: context =>
                               {
                                   var produto = context.GetArgument<Produto>("produto");
                                   return produtoRepository.Add(produto);
                               });

            Field<ProdutoType>("updateProduto",
                               "Atualiza um produto na base de dados",
                               arguments: new QueryArguments(
                                   new QueryArgument<NonNullGraphType<GuidGraphType>> { Name = "id", Description = "Id do Produto" },
                                   new QueryArgument<NonNullGraphType<ProdutoInputType>>
                                   {
                                       Name = "produto",
                                       Description = "Produto input parameter"
                                   }),
                               resolve: context =>
                               {
                                   var idProduto = context.GetArgument<Guid>("id");
                                   var produto = context.GetArgument<Produto>("produto");
     
                                   return produtoRepository.Update(idProduto, produto);
                               });

            Field<ProdutoType>("deleteProduto",
                               "Deleta um produto na base de dados",
                               arguments: new QueryArguments(
                                   new QueryArgument<NonNullGraphType<GuidGraphType>> { Name = "id", Description = "Id do Produto" }),
                               resolve: context =>
                               {
                                   var idProduto = context.GetArgument<Guid>("id");  
                                   produtoRepository.Delete(idProduto);
                                   return true;
                               });
        }
    }
}

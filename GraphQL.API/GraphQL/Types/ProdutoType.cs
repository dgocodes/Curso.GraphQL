using GraphQL.Types;

namespace GraphQL.API.GraphQL.Types
{
    public class ProdutoType : ObjectGraphType<Produto>
    {
        //Convertendo os campos para os tipos aceitos no graphql
        public ProdutoType()
        {
            Field(x => x.Id, type: typeof(IdGraphType)).Description("Id do Produto");
            Field(x => x.Nome, type: typeof(StringGraphType)).Description("Nome do Produto");
            Field(x => x.Categoria, type: typeof(StringGraphType)).Description("Categoria do Produto");
            Field(x => x.Valor, type: typeof(DecimalGraphType)).Description("Valor do Produto");
            Field(x => x.Status, type: typeof(IntGraphType)).Description("Status do Produto");
            Field(x => x.DataCadastro, type: typeof(DateOnlyGraphType)).Description("Data do cadastro do Produto");
        }
    }
}

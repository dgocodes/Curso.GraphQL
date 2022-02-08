using GraphQL.Types;

namespace GraphQL.API.GraphQL.Types
{
    public class ProdutoInputType : InputObjectGraphType
    {
        public ProdutoInputType()
        {
            Name = "ProdutoInputType";

            Field<StringGraphType>("Nome");
            Field<StringGraphType>("Categoria");
            Field<DecimalGraphType>("Valor");

            Field<ListGraphType<AvaliacaoInputType>>("Avaliacoes");
        }
    }
}

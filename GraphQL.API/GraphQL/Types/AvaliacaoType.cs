using GraphQL.API.Models;
using GraphQL.Types;

namespace GraphQL.API.GraphQL.Types
{
    public class AvaliacaoType : ObjectGraphType<Avaliacao>
    {
        //Convertendo os campos para os tipos aceitos no graphql
        public AvaliacaoType()
        {
            Field(x => x.Nota, type: typeof(IntGraphType)).Description("Nota do Produto");
            Field(x => x.Comentario, type: typeof(StringGraphType)).Description("Comentario sobre o produto");
        }
    }
}

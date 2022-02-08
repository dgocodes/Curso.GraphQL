using GraphQL.Types;

namespace GraphQL.API.GraphQL.Types
{
    public class AvaliacaoInputType : InputObjectGraphType
    {
        public AvaliacaoInputType()
        {
            Name = "AvaliacaoInputType";

            Field<IntGraphType>("Nota");
            Field<StringGraphType>("Comentario");
        }
    }
}

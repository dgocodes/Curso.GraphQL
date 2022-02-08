using GraphQL.API.GraphQL.Queries;
using GraphQL.Types;

namespace GraphQL.API.GraphQL
{
    public class AppSchema : Schema
    {
        public AppSchema(ProdutoQuery query)
        {
            this.Query = query;
        }
    }
}

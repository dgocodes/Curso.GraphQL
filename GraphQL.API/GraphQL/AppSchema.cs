using GraphQL.API.GraphQL.Mutations;
using GraphQL.API.GraphQL.Queries;
using GraphQL.Types;

namespace GraphQL.API.GraphQL
{
    public class AppSchema : Schema
    {
        public AppSchema(ProdutoQuery query, ProdutoMutation mutation)
        {
            this.Query = query;
            this.Mutation = mutation;
        }
    }
}

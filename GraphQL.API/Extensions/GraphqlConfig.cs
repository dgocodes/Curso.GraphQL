using GraphQL.API.GraphQL;
using GraphQL.API.GraphQL.Queries;
using GraphQL.Server;

public static class GraphqlConfig
{
    public static IServiceCollection AddConfigGraphQL(this IServiceCollection services)
    {
        services.AddScoped<ProdutoQuery>();
        services.AddScoped<AppSchema>();

        services.AddGraphQL()
                .AddSystemTextJson();

        return services;
    }

    public static IApplicationBuilder UseConfigGraphQL(this IApplicationBuilder app)
    {
        app.UseGraphQL<AppSchema>();
        app.UseGraphQLGraphiQL("/ui/graphql");

        return app;
    }
}


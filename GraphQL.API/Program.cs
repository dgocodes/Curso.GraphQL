using GraphQL.API.Repository;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSingleton<IProdutoRepository, ProdutoRepository>();

//GraphQL
builder.Services.AddConfigGraphQL();

var app = builder.Build();

//GraphQL 
app.UseConfigGraphQL();
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();

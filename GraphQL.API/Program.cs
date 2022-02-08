using GraphQL.API.Repository;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<IProdutoRepository, ProdutoRepository>();

//GraphQL
builder.Services.AddConfigGraphQL();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

//GraphQL 
app.UseConfigGraphQL();

app.UseAuthorization();

app.MapControllers();

app.Run();

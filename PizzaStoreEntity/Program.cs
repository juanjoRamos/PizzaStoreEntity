using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using PizzaStoreEntity;
using PizzaStoreEntity.Models;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("Pizzas") ?? "Data Source=Pizzas.db";
//builder.Services.AddDbContext<PizzasDb>(options => options.UseInMemoryDatabase("Items"));
builder.Services.AddSqlite<PizzasDb>(connectionString);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "PizzaStore API",
        Description = "Making the Pizzas you love",
        Version = "v1"
    }));

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "PizzaStore API V1"));

app.MapGet("/", () => "Hello World!");

app.MapGet("/pizzas", async (PizzasDb Db) => 
{
    var Lista = await Db.Pizzas.ToListAsync(); 
    return Results.Ok(Lista);
});

app.MapGet("/pizza/{id}", async (PizzasDb Db, int id) => 
{
    await Db.Pizzas.FindAsync(id); 
});

app.MapPost("/pizza", async (PizzasDb Db, Pizza pizza) => {
    await Db.Pizzas.AddAsync(pizza);
    await Db.SaveChangesAsync();
    Results.Created($"/pizza/{pizza.Id}", pizza);
});

app.MapPut("/pizza/{id}", async (PizzasDb db, Pizza updatepizza, int id) =>
{
      var pizza = await db.Pizzas.FindAsync(id);

      if (pizza is null) 
        return Results.NotFound();
      
      pizza.Name = updatepizza.Name;
      pizza.Description = updatepizza.Description;
      
      await db.SaveChangesAsync();    
      return Results.NoContent();
});

app.MapDelete("/pizza/{id}", async (PizzasDb db, int id) =>
{
   var pizza = await db.Pizzas.FindAsync(id);

   if (pizza is null)
      return Results.NotFound();
   
   db.Pizzas.Remove(pizza);
   
   await db.SaveChangesAsync();
   return Results.Ok();
});

app.Run();

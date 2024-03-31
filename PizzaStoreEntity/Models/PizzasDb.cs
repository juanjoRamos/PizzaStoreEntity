using Microsoft.EntityFrameworkCore;
using PizzaStoreEntity.Models;

namespace PizzaStoreEntity;

public class PizzasDb : DbContext
{
    //Creamos el contexto de la bbdd en el constructor
    public PizzasDb(DbContextOptions contextOptions) : base(contextOptions){}

    //Creamos las tablas
    public DbSet<Pizza> Pizzas {get; set;} = null!;

}

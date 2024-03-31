Crear una minimal api con la que poder hacer las mismas operaciones que se hicieron en el repo "PizzaStoreApi", pero en esta ocasión añadiremos Entity Framework Core.
Lo que tenemos que hacer es instalar entity framework, sus tools y el design.

Para instalar Entity Framework Core
> dotnet add package Microsoft.EntityFrameworkCore.SqlServer

El siguiente paso es instalar las Tools
> dotnet tool install --global dotnet-ef

El último paso es instalar el Design
> dotnet add package Microsoft.EntityFrameworkCore.Design

Ahora pasamos a instalar Swagger:
> dotnet add package Swashbuckle.AspNetCore --version 6.5.0

Lo que vamos a hacer ahora es en lugar de crear una base de datos con el mismo Entity, lo que vamos a hacer es usar la memoria mientras el programa esté en ejecución.
Para ello vamos a utilizar:
> dotnet add package Microsoft.EntityFrameworkCore.InMemory --version 8.0

Ultimo paso: 
Creacion de endpoints, crud para poder trabajar con las pizzas. Tambien se ha hecho que entity use la memoria del equipo mientras este programa esté depurando.

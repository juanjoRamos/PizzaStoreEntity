Crear una minimal api con la que poder hacer las mismas operaciones que se hicieron en el repo "PizzaStoreApi", pero en esta ocasión añadiremos Entity Framework Core.
Lo que tenemos que hacer es instalar entity framework, sus tools y el design.

Para instalar Entity Framework Core
> dotnet add package Microsoft.EntityFrameworkCore.SqlServer

El siguiente paso es instalar las Tools
> dotnet tool install --global dotnet-ef

El último paso es instalar el Design
> dotnet add package Microsoft.EntityFrameworkCore.Design

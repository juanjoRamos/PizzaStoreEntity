# Pizza Store #

## Descripción ##
Crear una minimal api con la que poder hacer las mismas operaciones que se hicieron en el repo "PizzaStoreApi".
En este proyecto vamos a utilizar en primer lugar Entity Framework Core para realizar las consultas básicas para un CRUD. Usaremos **InMemory**,
su funcionamiento se basa en que los datos serán volátiles.

Después de esto vamos a usar como proveedor de Base de datos SQLite para que nustros datos sean persistentes.

## Entity Framework Core ##

**Paso 1:** Instalar Entity Framework Core.
> dotnet add package Microsoft.EntityFrameworkCore.SqlServer

**Paso 2:** Instalar las Tools.
> dotnet tool install --global dotnet-ef

**Paso 3:** Instalar el Design.
> dotnet add package Microsoft.EntityFrameworkCore.Design

**Paso 4:** Instalar InMemory
> dotnet add package Microsoft.EntityFrameworkCore.InMemory --version 8.0

## Swagger ##
 **Paso 1:** Instalación de swagger. 
> dotnet add package Swashbuckle.AspNetCore --version 6.5.0

## SQLite ##
**Paso 1:** Instalación de SQLite
> dotnet add package Microsoft.EntityFrameworkCore.Sqlite --version 8.0

Después de poner la cadena de conexión en el archivo Program haremos la migración de la base de datos:

> dotnet ef migrations add InitialCreate
> dotnet ef database update


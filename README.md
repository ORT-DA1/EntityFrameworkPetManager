# EntityFrameworkPetManager
Ejemplo simple de uso de EF Code First armando un administrador de datos de mascotas

## Requisitos

1) Visual Studio 2015 o superior

2) SQL Server Express 2012 o superior instalado

3) Tener el servicio de SQL Server iniciado.

![image](https://github.com/ORT-DA1/EntityFrameworkPetManager/blob/master/img/service.png)

4) Opcional: Se aconseja tener el SQL Server Management Studio para ver de forma simple cómo vamos manipulando la base.

## Pasos para ejecutar el proyecto:

1) Clonar o descargar el repositorio

2) Modificar el archivo de configuración app.config que contiene la información de conexión con nuestra base de datos de SQL Server. Ahí se debe indicar el nombre de nuestra instancia de la BD.

Esta es la sección a modificar:

```xml
  <connectionStrings>
    <add name="PetManagerConnectionString"
    connectionString="Data Source=GABRIEL;Initial Catalog=PetManagerDatabase;Integrated Security=true"
    providerName="System.Data.SqlClient"/>
  </connectionStrings>
 ```

Donde dice **GABRIEL** se debe poner el **nombre de su instancia de SQLSERVER**.

```xml
  <connectionStrings>
    <add name="PetManagerConnectionString"
    connectionString="Data Source=NOMBRE_DE_TU_INSTANCIA;Initial Catalog=PetManagerDatabase;Integrated Security=true"
    providerName="System.Data.SqlClient"/>
  </connectionStrings>
```  

Dicho nombre puede ser fácilmente visto desde SQL Server Management Studio.

![image](https://github.com/ORT-DA1/EntityFrameworkPetManager/blob/master/img/nombreinstancia.png)


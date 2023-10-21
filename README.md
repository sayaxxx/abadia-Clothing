
# FILTRO CLOTHING

- Este es un Proyecto .Net 4 Capas en el cual hacemos una gestion para una tienda de ropa.

🎱 Requerimientos
-------------------

#### Endpoints requeridos
1. Listar los insumos que pertenecen a una prenda especifica. El usuario debe ingresar el código de la prenda.

2. Listar los Insumos que son vendidos por un determinado proveedor cuyo tipo de persona sea Persona Jurídica. El usuario debe ingresar el Nit de proveedor.

3. Listar todas las ordenes de producción cuyo estado se en proceso.

4. Listar los empleados por un cargo especifico. Los cargos que se encuentran en la empresa son: Auxiliar de Bodega, Jefe de Producción, Corte, Jefe de bodega, Secretaria, Jefe de IT.

5. Listar las ordenes de producción que pertenecen a un cliente especifico. El usuario debe ingresar el IdCliente y debe obtener la siguiente información:

 - IdCliente, Nombre, Municipio donde se encuentra ubicado.
 - Nro de orden de producción, fecha y el estado de la orden de producción (Se debe      mostrar la descripción del estado, código del estado, valor total de la orden de  producción.
 - Detalle de orden: Nombre de la prenda, Código de la prenda, Cantidad, Valor total en  pesos y en dólares.
 
 
6. Listar las ventas realizadas por un empleado especifico. El usuario debe ingresar el Id del empleado y mostrar la siguiente información.

 - Id Empleado
 - Nombre del empleado
 - Fecturas : Nro Factura, fecha y total de la factura.

7. Listar los productos y tallas del inventario. La consulta debe mostrar el id del inventario, nombre del producto, tallas y cantidad de cada talla.

## Requerimientos Funcionales
El proyecto de administración de veterinaria debe cumplir con los siguientes requerimientos funcionales:

1. Implementar restricción de peticiones haciendo uso de limitaciones de peticiones por IP.
2. Implementar protección a los endPoints haciendo uso de JWT y roles de usuario.
3. Implementar esquema de versionado de Api que facilite el proceso de implementación de nuevos endpoints sin afectar el funcionamiento de las aplicaciones externas que consumen los servicios del Api.
4. Implementar endpoints que permitan realizar el proceso de CRUD en cada uno de los controladores del backend.
5. Debido al gran volumen de información que la empresa procesa diariamente se requiere que los endpoints encargados de consultar el contenido de las tablas implementen sistema de paginación.
## ▶️ USO DEL PROGRAMA

- Clonar el repositorio
- Encender nuestra conexion y/o base de datos
- Correr las migraciones

```bash
  dotnet ef migrations add InitialMigration --project .\Persistencia\ --startup-project .\API\ --output-dir .\data\Migrations
```
- Luego subir la migracion 
```bash
dotnet ef database update --project .\Persistencia\ --startup-project .\API\
```
- Situarnos en cd ./API/ y ejecutar el comando:
```bash
dotnet run
```
## 🔐 GENERACION DEL TOKEN Y REGISTRO USUARIO
- Antes de hacer consultas debemos generar un token para el administrador. Para esto usamos Thunder, Postman o API REST e introducimos lo siguiente:

```bash
POST

http://localhost:5272/api/usuario/token

{
       "Nombre": "admin",
       "password": "123"
}
```
- Si todo esta bien nos deberia aparecer el Token

![image](https://github.com/sayaxxx/veterinaria/assets/133735883/432e4d08-eb3b-4da1-b2d7-bc7f4e7c8b09)

- Una vez logeados como administradores procedemos a agregar usuarios y esto lo hacemos de la siguiente forma:

```bash
POST

http://localhost:5272/api/usuario/register

{
      "Nombre": "nombreUsuario",
      "password": "password",
      "Email": "email"
}
```
![image](https://github.com/sayaxxx/veterinaria/assets/133735883/f5a7c6a8-c6cb-42f9-a35e-03128c063079)

- De esta manera registramos un nuevo usuario de manera exitosa

- Luego de tener el usuario, podemos ir a generar el refresh token, y esto lo hacemos de la siguiente manera:

```bash
POST

http://localhost:5272/api/usuario/refresh-token

{
      "Nombre": "nombreUsuario",
      "password": "password"
}
```
![image](https://github.com/sayaxxx/veterinaria/assets/133735883/c5de99cd-9be2-4f3d-90ee-2a538d89c2a1)

- Y de esta forma hemos obtenido exitosamente el RefreshToken y ahora si podemos proceder con los endpoints.

## ⚕️ ENDPOINT 1B

- Listar los proveedores que sean persona natural.
- IMPORTANTE: Para poder hacer con exito las consultas debemos tener el token del administrador ya que este es el que tiene los privilegios para poder hacerlo.

```bash
GET

http://localhost:5272/api/proveedor/ObtenerProveedoresNaturales
```
![image](https://github.com/sayaxxx/veterinaria/assets/133735883/6091b207-a0c6-4a1a-b2e4-1b5a067a4220)

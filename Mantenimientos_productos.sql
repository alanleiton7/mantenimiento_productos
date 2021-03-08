create database Mantenimientos_productos
use Mantenimientos_productos

 --TABLA  CATEGORIA----------------------------------
create table categoria(
id_categoria int identity(1,1) primary key,
codigo int,
nombre varchar(50),
descripcion varchar(250)

)

--PROCEDIMIENTOS ALMACENADOS--

--procedimiento almacenado buscar categoria--
create proc sp_buscar_categoria
@buscar varchar(50)
as
select * from categoria 
where nombre like @buscar + '%'

--procedimiento almacenado insertar categoria
create proc sp_insertar_categoria
@codigo int,
@nombre varchar(50),
@descripcion varchar(250)
as
insert into categoria values( @codigo, @nombre,@descripcion)

--procedimiento almacenado editar categoria
create proc sp_editar_categoria
@id_categoria int,
@codigo int,
@nombre varchar(50),
@descripcion varchar(250)
as
update categoria set codigo = @codigo, nombre = @nombre, descripcion = @descripcion
where id_categoria = @id_categoria

--procedimiento almacenado eliminar categoria
create proc sp_eliminar_categoria
@id_categoria int
as
Delete categoria where id_categoria = @id_categoria

select * from categoria
---cantidad de categorias---



 --TABLA  MARCA----------------------------------
 
create table marca(
id_marca int identity(1,1) primary key,
codigo int,
nombre varchar(50),
descripcion varchar(250)

)

--PROCEDIMIENTOS ALMACENADOS--

--procedimiento almacenado buscar marca--
create proc sp_buscar_marca
@buscar varchar(50)
as
select * from marca 
where nombre like @buscar + '%'

--procedimiento almacenado insertar marca
create proc sp_insertar_marca
@codigo int,
@nombre varchar(50),
@descripcion varchar(250)
as
insert into marca values( @codigo, @nombre,@descripcion)

--procedimiento almacenado editar marca
create proc sp_editar_marca
@id_marca int,
@codigo int,
@nombre varchar(50),
@descripcion varchar(250)
as
update marca set codigo = @codigo, nombre = @nombre, descripcion = @descripcion
where id_marca = @id_marca

--procedimiento almacenado eliminar marca
create proc sp_eliminar_marca
@id_marca int
as
Delete marca where id_marca = @id_marca

select * from marca

 --TABLA  PRODUCTOS----------------------------------

 create  table productos(
 
 id_producto int identity(1,1) primary key not null,
 codigo int,
 producto nvarchar(100) not null,
 precio_compra decimal(18,2) not null,
 precio_venta  decimal(18,2) not null,
 stock int not null,
 
 --foreign key--
 fk_id_marca int not null foreign key (fk_id_marca) references marca(id_marca),
 fk_id_categoria int not null foreign key (fk_id_categoria) references categoria(id_categoria),


 )

 insert into productos values(1,'super taladro',12.50,20,100,10,1)
 
 insert into productos values(2,'martillo',12.50,20,100,11,1)
 
 insert into productos values(3,'cerrucho',12.50,20,100,12,1)


  --procedimiento almacenado listar 100 primeros productos

 create   proc sp_listar_productos
 as 
 select top 100
 productos.id_producto,
 productos.codigo,
 productos.producto,
 productos.fk_id_categoria,
 categoria.nombre as categoria,
 productos.fk_id_marca,
 marca.nombre as marcas,
 productos.precio_compra,
 productos.precio_venta,
 productos.stock
 from productos 
 inner join categoria on productos.fk_id_categoria = categoria.id_categoria
 inner join marca on productos.fk_id_marca = marca.id_marca
 order by id_producto asc

 exec sp_listar_productos


 select * from marca
 select * from categoria
 
  --procedimiento almacenado buscar productos--

 create   proc sp_buscar_producto
@buscar varchar(50)
as
select top 100
 productos.id_producto,
 productos.codigo,
 productos.producto,
 productos.fk_id_categoria,
 categoria.nombre as categoria,
 productos.fk_id_marca,
 marca.nombre as marcas,
 productos.precio_compra,
 productos.precio_venta,
 productos.stock
 from productos 
 inner join categoria on productos.fk_id_categoria = categoria.id_categoria
 inner join marca on productos.fk_id_marca = marca.id_marca
where producto like @buscar + '%'
order by id_producto asc
exec sp_listar_productos
exec sp_buscar_producto 'm'
 --procedimiento insertar producto 

 create proc sp_insertar_productos
 
 @codigo int,
 @producto nvarchar(100),
 @precio_compra decimal(18,2),
 @precio_venta  decimal(18,2),
 @stock int,
 @fk_id_marca int,
 @fk_id_categoria int 
as
insert into productos values( @codigo, @producto,@precio_compra,@precio_venta,@stock,@fk_id_marca,@fk_id_categoria)



--procedimiento modificar productos--

create proc sp_editar_productos
 @id_producto int,
 @codigo int,
 @producto nvarchar(100),
 @precio_compra decimal(18,2),
 @precio_venta  decimal(18,2),
 @stock int,
 @fk_id_marca int,
 @fk_id_categoria int 
as
update productos set codigo = @codigo, producto = @producto, precio_compra = @precio_compra,
precio_venta = @precio_venta, stock = @stock, fk_id_marca = @fk_id_marca, fk_id_categoria = @fk_id_categoria
where id_producto = @id_producto


--procedimiento eliminar producto--

create proc sp_eliminar_productos
@id_producto int
as
Delete productos where id_producto = @id_producto















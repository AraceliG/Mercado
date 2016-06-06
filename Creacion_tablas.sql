USE GD1C2016;
/******************************************************************************/
-- Creamos el esquema
/******************************************************************************/

IF NOT EXISTS (SELECT schema_name FROM   information_schema.SCHEMATA WHERE  schema_name = 'NOTHING_IS_IMPOSSIBLE')
    EXEC('CREATE SCHEMA NOTHING_IS_IMPOSSIBLE');
GO

/******************************************************************************/
-- Creamos las tablas y las vamos llenando
/******************************************************************************/

-- --> Funcionalidad <-- --
CREATE TABLE NOTHING_IS_IMPOSSIBLE.Funcionalidad 
( 
	cod_funcionalidad numeric(18, 0) IDENTITY NOT NULL PRIMARY KEY, 
	nombre nvarchar(255)
)

INSERT INTO NOTHING_IS_IMPOSSIBLE.Funcionalidad (nombre) 
VALUES      ('Login y Seguridad'), 
            ('AMB de Rol'), 
            ('ABM de Usuarios'), 
            ('ABM de Rubro'), 
            ('ABM de visibilidad de publicacion'), 
            ('Generar Publicacion'), 
            ('Comprar/Ofertar'), 
            ('Historial del cliente'), 
            ('Calificar al Vendedor'), 
            ('Consulta de facturas realizadas al vendedor'), 
            ('Listado Estadistico')
GO

-- --> Rol <-- --
CREATE TABLE NOTHING_IS_IMPOSSIBLE.Rol 
( 
     cod_rol numeric(18, 0) IDENTITY NOT NULL PRIMARY KEY, 
     nombre nvarchar(255), 
     baja bit,
	 habilitado bit 
)    

INSERT INTO NOTHING_IS_IMPOSSIBLE.Rol (nombre, baja, habilitado) 
VALUES      ('Empresa', 0, 1), 
            ('Cliente', 0, 1),
			('Administrativo', 0, 1)
GO

-- --> RolFuncionalidad <-- --
CREATE TABLE NOTHING_IS_IMPOSSIBLE.RolFuncionalidad 
( 
     cod_funcionalidad numeric(18, 0) FOREIGN KEY REFERENCES NOTHING_IS_IMPOSSIBLE.Funcionalidad(cod_funcionalidad), 
     cod_rol numeric(18, 0) FOREIGN KEY REFERENCES NOTHING_IS_IMPOSSIBLE.Rol(cod_rol),
	 CONSTRAINT sinDuplicadosRolFunc UNIQUE(cod_funcionalidad,cod_rol) 
) 

INSERT INTO NOTHING_IS_IMPOSSIBLE.RolFuncionalidad (cod_funcionalidad, cod_rol)
VALUES (1,1),(1,2),(1,3),(2,3),(3,3),(4,3),(5,3),(6,1),(6,2),(7,2),(8,2),(9,2),(10,1),(10,2),(11,3)
GO

-- --> Rubro <-- --
CREATE TABLE NOTHING_IS_IMPOSSIBLE.Rubro 
( 
	cod_rubro numeric(18, 0) IDENTITY NOT NULL PRIMARY KEY, 
	descripcion_corta nvarchar(100),
	descripcion_larga nvarchar(255)
)

INSERT INTO NOTHING_IS_IMPOSSIBLE.Rubro (descripcion_corta,descripcion_larga) 
SELECT distinct replace(replace(replace(replace(replace(Publicacion_Rubro_Descripcion,'-',''),'/',''),'y',''), ',', ''),' ', ''), Publicacion_Rubro_Descripcion
	FROM [gd_esquema].[Maestra];
GO

-- --> TipoDocumento <-- --
CREATE TABLE NOTHING_IS_IMPOSSIBLE.TipoDocumento 
( 
	cod_tipo_doc numeric(18, 0) IDENTITY NOT NULL PRIMARY KEY, 
	descripcion nvarchar(255)
)

INSERT INTO NOTHING_IS_IMPOSSIBLE.TipoDocumento (descripcion) 
VALUES      ('DNI - Documento NAcional de Identidad')
GO

-- --> Usuario, Cliente, Empresa <-- --
CREATE TABLE NOTHING_IS_IMPOSSIBLE.Usuario 
( 
     username nvarchar(255) NOT NULL UNIQUE, 
     pass nvarchar(255), --password
	 userId numeric(18, 0) IDENTITY PRIMARY KEY,
	 email nvarchar(255),
	 telefono nvarchar(255),
	 calle nvarchar(255),
	 num_calle numeric(18,0),
	 piso numeric(18, 0),
	 depto nvarchar(50),
	 cod_postal nvarchar(50),
	 habilitado bit,
	 baja bit,
	 reputacion numeric(18,4),	   
     user_nro_intentos numeric(18, 0), 
)

-- --> RolUsuario <-- --
CREATE TABLE NOTHING_IS_IMPOSSIBLE.RolUsuario 
( 
     userId numeric(18, 0) FOREIGN KEY REFERENCES NOTHING_IS_IMPOSSIBLE.Usuario (userId), 
     cod_rol numeric(18, 0) FOREIGN KEY REFERENCES NOTHING_IS_IMPOSSIBLE.Rol(cod_rol)
)

CREATE TABLE NOTHING_IS_IMPOSSIBLE.Cliente  
( 
     userId numeric(18, 0) UNIQUE FOREIGN KEY REFERENCES NOTHING_IS_IMPOSSIBLE.Usuario(userId),
	 dni numeric(18, 0),
	 cod_tipo_doc numeric(18, 0) FOREIGN KEY REFERENCES NOTHING_IS_IMPOSSIBLE.TipoDocumento(cod_tipo_doc),
	 apellido nvarchar(255),
	 nombre nvarchar(255),
	 fecha_nacimiento datetime,
	 fechaCreacion datetime,
	 primary key (dni, cod_tipo_doc)

)
GO

CREATE TABLE NOTHING_IS_IMPOSSIBLE.Empresa
( 
     userId numeric(18, 0) UNIQUE FOREIGN KEY REFERENCES NOTHING_IS_IMPOSSIBLE.Usuario(userId),
	 cuit nvarchar(50) primary key,
	 razon_social nvarchar(50),
	 nombre_contaco nvarchar(225),
	 cod_rubro_principal numeric(18,0) FOREIGN KEY REFERENCES NOTHING_IS_IMPOSSIBLE.Rubro(cod_rubro),
	 ciudad nvarchar(255)
)
GO

CREATE PROCEDURE NOTHING_IS_IMPOSSIBLE.sp_altaCliente 
    @username nvarchar(255), 
    @pass nvarchar(255),	
	@email nvarchar(255),
	@telefono nvarchar(255),
	@calle nvarchar(255),
	@num_calle numeric(18,0),
	@piso numeric(18, 0),
	@depto nvarchar(50),
	@cod_postal nvarchar(50),
	@habilitado bit,
	@baja bit,
	@reputacion numeric(18,4),	   
    @user_nro_intentos numeric(18, 0),
    @dni numeric(18, 0),
	@cod_tipo_doc numeric(18, 0),
	@apellido nvarchar(255),
	@nombre nvarchar(255),
	@fecha_nacimiento datetime,
	@fechaCreacion datetime	
AS
BEGIN
	DECLARE @ultimoID numeric(18,0), @cod_rol numeric(18,0);

	-- alta user
	INSERT INTO NOTHING_IS_IMPOSSIBLE.Usuario 
		(username, pass, email, telefono, calle, num_calle, piso, depto, cod_postal, habilitado, baja, reputacion, user_nro_intentos) 
	VALUES
		(@username, @pass, @email, @telefono, @calle, @num_calle, @piso, @depto, @cod_postal, @habilitado, @baja, @reputacion, @user_nro_intentos);

	
	--SCOPE_IDENTITY: Esta funcion te retorna el último valor de identidad en el ámbito de ejecución actual. Es decir, el último autonumerico que realizó.
	select @ultimoID = scope_identity();
	
	-- alt cliente	
	INSERT INTO NOTHING_IS_IMPOSSIBLE.Cliente 
		(userId, dni, cod_tipo_doc, apellido, nombre, fecha_nacimiento, fechaCreacion) 
	VALUES
		(@ultimoID, @dni, @cod_tipo_doc, @apellido, @nombre, @fecha_nacimiento, @fechaCreacion);

	-- Le asocio el rol de cliente	
	select @cod_rol = (select cod_rol from NOTHING_IS_IMPOSSIBLE.Rol where nombre = 'Cliente');
	INSERT INTO NOTHING_IS_IMPOSSIBLE.RolUsuario 
		(userId, cod_rol) 
	VALUES
		(@ultimoID, @cod_rol);	
END
GO

CREATE PROCEDURE NOTHING_IS_IMPOSSIBLE.sp_altaEmpresa 
    @username nvarchar(255), 
    @pass nvarchar(255),	
	@email nvarchar(255),
	@telefono nvarchar(255),
	@calle nvarchar(255),
	@num_calle numeric(18,0),
	@piso numeric(18, 0),
	@depto nvarchar(50),
	@cod_postal nvarchar(50),
	@habilitado bit,
	@baja bit,
	@reputacion numeric(18,4),	   
    @user_nro_intentos numeric(18, 0),
	@cuit nvarchar(50),
	@razon_social nvarchar(50),
	@nombre_contaco nvarchar(225),
	@cod_rubro_principal numeric(18,0),
	@ciudad nvarchar(255)
AS
BEGIN
	DECLARE @ultimoID numeric(18,0), @cod_rol numeric(18, 0);
	-- alta user
	INSERT INTO NOTHING_IS_IMPOSSIBLE.Usuario 
		(username, pass, email, telefono, calle, num_calle, piso, depto, cod_postal, habilitado, baja, reputacion, user_nro_intentos) 
	VALUES
		(@username, @pass, @email, @telefono, @calle, @num_calle, @piso, @depto, @cod_postal, @habilitado, @baja, @reputacion, @user_nro_intentos);

	
	--SCOPE_IDENTITY: Esta funcion te retorna el último valor de identidad en el ámbito de ejecución actual. Es decir, el último autonumerico que realizó.
	select @ultimoID = scope_identity();
	
	-- alt Empresa	
	INSERT INTO NOTHING_IS_IMPOSSIBLE.Empresa 
		(userId, cuit, razon_social, nombre_contaco, cod_rubro_principal, ciudad) 
	VALUES
		(@ultimoID, @cuit, @razon_social, @nombre_contaco, @cod_rubro_principal, @ciudad);

	-- Le asocio el rol de Empresa	
	select @cod_rol = (select cod_rol from NOTHING_IS_IMPOSSIBLE.Rol where nombre = 'Empresa');
	INSERT INTO NOTHING_IS_IMPOSSIBLE.RolUsuario 
		(userId, cod_rol) 
	VALUES
		(@ultimoID, @cod_rol);	
	
END
GO

CREATE PROCEDURE NOTHING_IS_IMPOSSIBLE.sp_migrarClientes AS 
BEGIN
	DECLARE
		@dni numeric(18, 0),
		@apellido nvarchar(255),
		@nombre nvarchar(255),
		@fecha_nacimiento datetime,
		@email nvarchar(255),
		@calle nvarchar(255),
		@num_calle numeric(18,0),
		@piso numeric(18, 0),
		@depto nvarchar(50),
		@cod_postal nvarchar(50);
	 
	DECLARE cliente_cursor CURSOR FOR 
		select * from (
			select
			Publ_Cli_Dni as dni,
			Publ_Cli_Apeliido as apellido,
			Publ_Cli_Nombre as nombre,
			Publ_Cli_Fecha_Nac as fechaNac,
			Publ_Cli_Mail as email,
			Publ_Cli_Dom_Calle as calle,
			Publ_Cli_Nro_Calle as nroCalle,
			Publ_Cli_Piso as piso,
			Publ_Cli_Depto as depto,
			Publ_Cli_Cod_Postal as codPostal
			from [gd_esquema].[Maestra]
			union -- Union eliminate duplicate rows
			select
			Cli_Dni as dni,
			Cli_Apeliido as apellido,
			Cli_Nombre as nombre,
			Cli_Fecha_Nac as fechaNac,
			Cli_Mail as email,
			Cli_Dom_Calle as calle,
			Cli_Nro_Calle as nroCalle,
			Cli_Piso as piso,
			Cli_Depto as depto,
			Cli_Cod_Postal as codPostal
			from [gd_esquema].[Maestra] ) t
		where t.dni is not null;

	OPEN cliente_cursor

	FETCH NEXT FROM cliente_cursor 
	INTO @dni, @apellido, @nombre, @fecha_nacimiento, @email, @calle, @num_calle, @piso, @depto, @cod_postal

	WHILE @@FETCH_STATUS = 0
	BEGIN
		DECLARE
			@username nvarchar(255),
			@fechaCreacion datetime;

		select @username = @apellido + '.' + @nombre;
		select @fechaCreacion = getdate();

		EXEC NOTHING_IS_IMPOSSIBLE.sp_altaCliente 
			@username,
			@username, -- @pass
			@email,
			'', -- @telefono
			@calle,
			@num_calle,
			@piso,
			@depto,
			@cod_postal,
			1, -- @habilitado
			0, -- @baja
			0, -- @reputacion
			0, -- @user_nro_intentos
			@dni,
			1, -- @cod_tipo_doc
			@apellido,
			@nombre,
			@fecha_nacimiento,
			@fechaCreacion	
		
		FETCH NEXT FROM cliente_cursor 
		INTO @dni, @apellido, @nombre, @fecha_nacimiento, @email, @calle, @num_calle, @piso, @depto, @cod_postal
		
	END 
	CLOSE cliente_cursor;
	DEALLOCATE cliente_cursor;
END
GO

EXEC NOTHING_IS_IMPOSSIBLE.sp_migrarClientes;
GO

CREATE PROCEDURE NOTHING_IS_IMPOSSIBLE.sp_migrarEmpresas AS 
BEGIN
	DECLARE
		@cuit nvarchar(50),
		@razon_social nvarchar(50),		
		@ciudad nvarchar(255),
		@email nvarchar(255),
		@calle nvarchar(255),
		@num_calle numeric(18,0),
		@piso numeric(18, 0),
		@depto nvarchar(50),
		@cod_postal nvarchar(50);

	 
	DECLARE cliente_cursor CURSOR FOR 
		select * from (
			select distinct 
			[Publ_Empresa_Cuit],
			[Publ_Empresa_Razon_Social],
			[Publ_Empresa_Mail],
			[Publ_Empresa_Dom_Calle],
			[Publ_Empresa_Nro_Calle],
			[Publ_Empresa_Piso],
			[Publ_Empresa_Depto],
			[Publ_Empresa_Cod_Postal]
			from
			[gd_esquema].[Maestra]
			where [Publ_Empresa_Cuit] is not null ) tEmpresas;

	OPEN cliente_cursor

	FETCH NEXT FROM cliente_cursor 
	INTO @cuit, @razon_social, @email, @calle, @num_calle, @piso, @depto, @cod_postal

	WHILE @@FETCH_STATUS = 0
	BEGIN
		DECLARE
			@username nvarchar(255),
			@fechaCreacion datetime;

		select @username = 'Emp' + SUBSTRING (@razon_social, len('Razon Social nº:_') , len(@razon_social) - len('Razon Social nº:' ));
		select @fechaCreacion = getdate();

		EXEC NOTHING_IS_IMPOSSIBLE.sp_altaEmpresa 
			@username,
			@username, -- @pass
			@email,
			'', -- @telefono
			@calle,
			@num_calle,
			@piso,
			@depto,
			@cod_postal,
			1, -- @habilitado
			0, -- @baja
			0, -- @reputacion
			0, -- @user_nro_intentos
			@cuit,
			@razon_social,
			null, -- @nombre_contaco,
			null, -- @cod_rubro_principal,
			null --@ciudad 
		
		FETCH NEXT FROM cliente_cursor 
		INTO @cuit, @razon_social, @email, @calle, @num_calle, @piso, @depto, @cod_postal
		
	END 
	CLOSE cliente_cursor;
	DEALLOCATE cliente_cursor;
END
GO

EXEC NOTHING_IS_IMPOSSIBLE.sp_migrarEmpresas;
GO

-- --> TipoComisionEnvio <-- --
CREATE TABLE NOTHING_IS_IMPOSSIBLE.TipoComisionEnvio
(
	cod_tipo_comision char(1) PRIMARY KEY,
	descripcion nvarchar(255)
)

INSERT INTO NOTHING_IS_IMPOSSIBLE.TipoComisionEnvio (cod_tipo_comision, descripcion) 
VALUES      ('P', 'Porcentaje'), ('F', 'Fijo')
GO

-- --> Visibilidad <-- --
CREATE TABLE NOTHING_IS_IMPOSSIBLE.Visibilidad 
(
	cod_visibilidad numeric(18, 0) PRIMARY KEY NOT NULL,
	descripcion nvarchar(255) UNIQUE,
	comision_publicar numeric(18,2),
	comision_vender numeric(18, 2),
	permite_envios bit,
	cod_tipo_comision_envio char(1) FOREIGN KEY REFERENCES NOTHING_IS_IMPOSSIBLE.TipoComisionEnvio (cod_tipo_comision),
	valor_comision_envio numeric(18, 2)
)

INSERT INTO NOTHING_IS_IMPOSSIBLE.Visibilidad (cod_visibilidad, descripcion, comision_publicar, comision_vender, permite_envios, cod_tipo_comision_envio, valor_comision_envio) 
select distinct 
	Publicacion_Visibilidad_Cod,
	Publicacion_Visibilidad_Desc,
	Publicacion_Visibilidad_Precio,
	Publicacion_Visibilidad_Porcentaje,
	0, -- los migrados por default no hacen envios
	'P',
	0
	from [gd_esquema].[Maestra];	
GO

-- --> EstadoPubli <-- --
CREATE TABLE NOTHING_IS_IMPOSSIBLE.EstadoPubli
(
  cod_estadoPubli char(1) PRIMARY KEY NOT NULL,
  descripcion nvarchar(255)
)

INSERT INTO NOTHING_IS_IMPOSSIBLE.EstadoPubli (cod_estadoPubli, descripcion) 
VALUES      ('A', 'Activa'), ('B', 'Borrador'), ('F', 'Finalizada'), ('P', 'Pausa')
GO

-- --> TipoPublicacion <-- --
CREATE TABLE NOTHING_IS_IMPOSSIBLE.TipoPublicacion
(
	cod_tipo_publicacion char(1) PRIMARY KEY NOT NULL,
	descripcion nvarchar(255)
)

INSERT INTO NOTHING_IS_IMPOSSIBLE.TipoPublicacion (cod_tipo_publicacion, descripcion) 
Select distinct
	SUBSTRING (Publicacion_Tipo, 1, 1),
	Publicacion_Tipo
	from [gd_esquema].[Maestra]
GO

-- --> Publicacion <-- --
CREATE TABLE NOTHING_IS_IMPOSSIBLE.Publicacion
(
  cod_publicacion numeric(18,0) PRIMARY KEY NOT NULL,
  cod_tipo_publicacion char(1) FOREIGN KEY REFERENCES NOTHING_IS_IMPOSSIBLE.TipoPublicacion(cod_tipo_publicacion),
  userId numeric(18, 0) FOREIGN KEY REFERENCES NOTHING_IS_IMPOSSIBLE.Usuario(userId),
  facha_inicio datetime,
  fecha_vencimiernto datetime,
  stock numeric(18,0),
  precio numeric(18,2),
  costo numeric(18, 2),
  cod_visibilidad numeric(18,0) FOREIGN KEY REFERENCES NOTHING_IS_IMPOSSIBLE.Visibilidad(cod_visibilidad),
  cod_estadoPubli char(1) FOREIGN KEY REFERENCES NOTHING_IS_IMPOSSIBLE.EstadoPubli(cod_estadoPubli),
  descripción nvarchar(255),
  acepta_preguntas bit,
  ofrece_envios bit
)

INSERT INTO NOTHING_IS_IMPOSSIBLE.Publicacion (cod_publicacion, cod_tipo_publicacion, userId, facha_inicio, fecha_vencimiernto, stock, precio, costo, cod_visibilidad, cod_estadoPubli, descripción, acepta_preguntas, ofrece_envios)
(
Select 
	m.Publicacion_Cod,
	SUBSTRING (m.Publicacion_Tipo, 1, 1),
	c.userId,
	m.Publicacion_Fecha,
	m.Publicacion_Fecha_Venc,
	m.Publicacion_Stock,
	m.Publicacion_Precio,
	null,
	Publicacion_Visibilidad_Cod,
	CASE m.Publicacion_Estado WHEN 'Publicada' THEN 'A'	ELSE 'B' END,
	m.Publicacion_Descripcion,
	0,
	0
	from 
		[gd_esquema].[Maestra] m 
		inner join NOTHING_IS_IMPOSSIBLE.Cliente c 
		on m.Publ_Cli_Dni = c.dni
union-- union elimina duplicados
Select 
	m.Publicacion_Cod,
	SUBSTRING (m.Publicacion_Tipo, 1, 1),
	e.userId,
	m.Publicacion_Fecha,
	m.Publicacion_Fecha_Venc,
	m.Publicacion_Stock,
	m.Publicacion_Precio,
	null,
	Publicacion_Visibilidad_Cod,
	CASE m.Publicacion_Estado WHEN 'Publicada' THEN 'A' ELSE 'B' END,
	m.Publicacion_Descripcion,
	0,
	0
	from 
		[gd_esquema].[Maestra] m 
		inner join NOTHING_IS_IMPOSSIBLE.Empresa e
		on m.Publ_Empresa_Cuit = e.cuit
)
GO

-- --> RubroPublicacion <-- --
CREATE TABLE NOTHING_IS_IMPOSSIBLE.RubroPublicacion
(
  cod_publicacion numeric(18, 0) FOREIGN KEY REFERENCES NOTHING_IS_IMPOSSIBLE.Publicacion(cod_publicacion),
  cod_rubro numeric(18, 0) FOREIGN KEY REFERENCES NOTHING_IS_IMPOSSIBLE.Rubro(cod_rubro)
)

INSERT INTO NOTHING_IS_IMPOSSIBLE.RubroPublicacion(cod_publicacion,cod_rubro)
Select distinct 
	m.Publicacion_Cod,
	r.cod_rubro
	from 
		[gd_esquema].[Maestra] m 
		inner join NOTHING_IS_IMPOSSIBLE.Rubro r 
		on m.Publicacion_Rubro_Descripcion = r.descripcion_larga
GO

-- --> Estrellas <-- --
CREATE TABLE NOTHING_IS_IMPOSSIBLE.Estrellas 
(
	cant_estrellas numeric(18, 0) PRIMARY KEY,
	descripcion nvarchar(225)
)

INSERT INTO NOTHING_IS_IMPOSSIBLE.Estrellas (cant_estrellas,descripcion) 
VALUES      (1,'Pesimo'), 
            (2,'Malo'), 
            (3,'Regular'), 
            (4,'Bueno'), 
            (5,'Excelente')
GO

-- --> Compra <-- --
CREATE TABLE NOTHING_IS_IMPOSSIBLE.Compra
(
	cod_publicacion numeric(18, 0) FOREIGN KEY REFERENCES NOTHING_IS_IMPOSSIBLE.Publicacion(cod_publicacion),
	userId numeric(18, 0) FOREIGN KEY REFERENCES NOTHING_IS_IMPOSSIBLE.Usuario(userId),
	fecha datetime,
	cantidad numeric(18, 0),
	cant_estrellas numeric(18,0) FOREIGN KEY REFERENCES NOTHING_IS_IMPOSSIBLE.Estrellas(cant_estrellas),
	txt_libre_calif nvarchar(255)
)

-- En el viejo sistema todas las compras estan calificadas
INSERT INTO NOTHING_IS_IMPOSSIBLE.Compra(cod_publicacion,userId,fecha,cantidad,cant_estrellas, txt_libre_calif)
select 
	Publicacion_Cod, 
	userId, 
	Compra_Fecha, 
	Compra_Cantidad,
	CASE
		WHEN Calificacion_Cant_Estrellas = 1 or Calificacion_Cant_Estrellas = 2 THEN 1
		WHEN Calificacion_Cant_Estrellas = 3 or Calificacion_Cant_Estrellas = 4 THEN 2
		WHEN Calificacion_Cant_Estrellas = 5 or Calificacion_Cant_Estrellas = 6 THEN 3
		WHEN Calificacion_Cant_Estrellas = 7 or Calificacion_Cant_Estrellas = 8 THEN 4
		WHEN Calificacion_Cant_Estrellas = 9 or Calificacion_Cant_Estrellas = 10 THEN 5
	END,
	null
from gd_esquema.Maestra
	inner join NOTHING_IS_IMPOSSIBLE.Cliente
	on Cli_Dni=dni 
	and Compra_Cantidad is not null 
	and Calificacion_Cant_Estrellas is not null 
GO

-- --> Oferta <-- --
CREATE TABLE NOTHING_IS_IMPOSSIBLE.Oferta (
	cod_publicacion numeric(18, 0) FOREIGN KEY REFERENCES NOTHING_IS_IMPOSSIBLE.Publicacion(cod_publicacion),
	userId numeric(18, 0) FOREIGN KEY REFERENCES NOTHING_IS_IMPOSSIBLE.Usuario(userId),
	fecha datetime,
	monto numeric(18, 2),
	ganadora bit
)

INSERT INTO NOTHING_IS_IMPOSSIBLE.Oferta (cod_publicacion,userId,fecha,monto,ganadora)
select m.Publicacion_Cod, c.userId, m.Oferta_Fecha, m.Oferta_Monto,
	CASE
		WHEN m.Oferta_Monto = (
			select max(g.Oferta_Monto) 
			from [gd_esquema].[Maestra] as g
			where g.Publicacion_Tipo ='Subasta'
				and m.Publicacion_Cod = g.Publicacion_Cod
				and Oferta_Monto is not null )
		THEN 1
		ELSE 0
	END
from [gd_esquema].[Maestra] as m
inner join NOTHING_IS_IMPOSSIBLE.Cliente c
	on m.Cli_Dni=c.dni
	and Publicacion_Tipo ='Subasta'
	and Oferta_Monto is not null
GO

-- --> Concepto <-- --
CREATE TABLE NOTHING_IS_IMPOSSIBLE.Concepto
(
	cod_concepto numeric(18, 0) PRIMARY KEY,
	descripcion nvarchar(255)
)

INSERT INTO NOTHING_IS_IMPOSSIBLE.Concepto (cod_concepto,descripcion) 
VALUES      (1,'Comision publicar'), 
            (2,'Comision vender'), 
            (3,'Gastos Envio'), 
            (4,'Otros'),
			(5,'Visibilidad "Gratis"')
GO

-- --> factura <-- --
CREATE TABLE NOTHING_IS_IMPOSSIBLE.Factura 
(
	nro_factura numeric(18, 0) PRIMARY KEY,
	cod_publicacion numeric(18, 0) FOREIGN KEY REFERENCES NOTHING_IS_IMPOSSIBLE.Publicacion(cod_publicacion),
	userId numeric(18, 0) FOREIGN KEY REFERENCES NOTHING_IS_IMPOSSIBLE.Usuario(userId),
	fecha datetime,
	total numeric(18, 2),
	forma_pago_desc nvarchar(255)
)

-- --> ItemFactura <-- --
CREATE TABLE NOTHING_IS_IMPOSSIBLE.ItemFactura
(
	nro_factura numeric(18, 0) FOREIGN KEY REFERENCES NOTHING_IS_IMPOSSIBLE.Factura(nro_factura),
	nro_item numeric(18, 0),
	cod_concepto numeric(18, 0) FOREIGN KEY REFERENCES NOTHING_IS_IMPOSSIBLE.Concepto(cod_concepto),
	monto numeric(18, 2),
	cantidad numeric(18, 0),
	PRIMARY KEY (nro_factura,nro_item)
)

INSERT INTO NOTHING_IS_IMPOSSIBLE.Factura (nro_factura,cod_publicacion,userId,fecha,total,forma_pago_desc) 
select 
	m.Factura_Nro,
	m.Publicacion_Cod,
	c.userId,
	m.Factura_Fecha,
	m.Factura_Total,
	m.Forma_Pago_Desc
from [gd_esquema].[Maestra] as m
	inner join NOTHING_IS_IMPOSSIBLE.Cliente as c
	on m.Publ_Cli_Dni = c.dni
	and m.Factura_Nro is not null
union -- union quita los repetidos
select 
m.Factura_Nro,
m.Publicacion_Cod,
e.userId,
m.Factura_Fecha,
m.Factura_Total,
m.Forma_Pago_Desc
from [gd_esquema].[Maestra] as m
inner join NOTHING_IS_IMPOSSIBLE.Empresa as e
	on m.Publ_Empresa_Cuit = e.cuit
	and m.Factura_Nro is not null


INSERT INTO NOTHING_IS_IMPOSSIBLE.ItemFactura (nro_factura,nro_item,cod_concepto,monto,cantidad) 
select Factura_Nro,
	ROW_NUMBER() OVER(PARTITION BY Factura_Nro ORDER BY Item_Factura_Monto ) AS Row,
 	CASE
		WHEN Publicacion_Visibilidad_Desc = 'Gratis' and Item_Factura_Monto = 0 THEN 5 -- Visibilidad "Gratis"
		WHEN Item_Factura_Monto = Publicacion_Visibilidad_Precio THEN 1 -- comision por publicar		
		ELSE 2 -- comision por vender
	END,
	Item_Factura_Monto,
	Item_Factura_Cantidad
from [gd_esquema].[Maestra] 
where Item_Factura_Monto is not null
order by 1
GO

-- EXEC NOTHING_IS_IMPOSSIBLE.sp_actualizar reputacion usuario;

 

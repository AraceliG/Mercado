CREATE PROCEDURE NOTHING_IS_IMPOSSIBLE.sp_listar_roles @username nvarchar(255)
AS
BEGIN 
(SELECT r.nombre
FROM Rol r
INNER JOIN RolUsuario ru ON ru.cod_rol = r.cod_rol
INNER JOIN Usuario u ON u.userId = ru.userId
WHERE u.userId = @username)
END
GO;

--valida que la contraseña y el usuario coincidan
--Check sintaxis de comparación
CREATE FUNCTION NOTHING_IS_IMPOSSIBLE.fx_login (@username nvarchar(255), @pass nvarchar(255))
RETURNS BOOLEAN AS
BEGIN
RETURN((SELECT COUNT(*) FROM Usuario WHERE userId = @usuario AND pass = @pass)=1)
END
GO;

--SP de validación de login
--Acá podría verse qué retornar. Quizás distintos valores numéricos, y dependiendo del valor, que la aplicación se fije qué significa cada valor.
--No sé por qué me da problemas el ELSE
CREATE PROCEDURE NOTHING_IS_IMPOSSIBLE.sp_login(@username nvarchar(255), @pass nvarchar(255))
AS
BEGIN 
DECLARE @intentos DECIMAL(1)
SET @intentos = (SELECT user_nro_intentos FROM Usuario WHERE userId = @username)
IF (@intentos < 3)
BEGIN 
	IF (fx_login(@username @pass))
	BEGIN 
		UPDATE Usuario SET nro_intentos = 0 WHERE userId = @username
		RETURN 1
	END
	ELSE
	BEGIN
		UPDATE Usuario SET nro_intentos = @intentos + 1 WHERE userId = @username
		RETURN 0
	END
END
ELSE RETURN 'El usuario se encuentra inhabilitado debido a que se ingresó una contraseña incorrecta más de 3 veces' 
END
GO;


--Deshabilita a un usuario con tres intentos fallidos. Se activa cada vez que la columna user_nro_intentos de Usuario es modificada
CREATE TRIGGER tr_dehabilitar_user_intentos_fallidos
ON Usuario
AFTER UPDATE
AS
BEGIN
IF UPDATE(user_nro_intentos)
	UPDATE Usuario
	SET habilitado = 0
	WHERE user_nro_intentos = 3 AND habilitado = 1
END
GO;


--Le quita rol a aquellos usuarios que tengan asignado un rol que esté inhabilitado. Se activa cada vez que la columna habilitado de Rol es modificada
CREATE TRIGGER tr_quitar_roles_deshabilitados
ON Rol
AFTER UPDATE 
AS
BEGIN
IF UPDATE(habilitado)
UPDATE RolUsuario 
SET cod_rol = NULL
WHERE cod_rol IN (SELECT cod_rol FROM Rol
					WHERE habilitado = 0)
END
GO;



CREATE PROCEDURE NOTHING_IS_IMPOSSIBLE.sp_buscar_cliente(@nombre nvarchar(255), @apellido nvarchar(255), @dni numeric(18,0), @email nvarchar(255))
AS
BEGIN
SELECT u.*, c.* FROM Usuario u, Cliente c
WHERE u.userId = c.cod_usuario
AND c.nombre LIKE COALESCE('%' + @nombre + '%', '%%')
AND c.apellido LIKE COALESCE('%' + @apellido + '%', '%%')
AND c.dni = @dni
AND u.email LIKE COALESCE('%' + @email + '%', '%%')
END;

CREATE PROCEDURE NOTHING_IS_IMPOSSIBLE.sp_buscar_empresa(@nombre varchar, @apellido varchar, @dni decimal, @email varchar)
AS
BEGIN
SELECT * FROM Usuario u, Empresa e
WHERE u.userId = e.cod_usuario
AND razon_social LIKE COALESCE('%' + @razon_social + '%', '%%')
AND cuit = @cuit
AND email LIKE COALESCE('%' + @email + '%', '%%')
END;

--Devuelve TRUE si el usuario es dueño de la publicación (por lo que se mostraría una ventana) y FALSE si no lo es (otra ventana)
--Check sintaxis comparación
CREATE PROCEDURE NOTHING_IS_IMPOSSIBLE.sp_publicacion_propia(@usuario nvarchar(255), @publicacion numeric(18,0))
AS
BEGIN
RETURN ((SELECT COUNT(*) FROM Publicacion
WHERE cod_publicacion = @publicacion
AND userId = @usuario) > 0)
END
GO;


--Clientes con mayor cantidad de productos comprados por mes y por año dentro de un rubro particular
CREATE PROCEDURE NOTHING_IS_IMPOSSIBLE.sp_listado_top_clientes_productos_rubro (@rubro nvarchar(100))
AS
BEGIN
SELECT cli.cod_usuario, COUNT(pub.*)
FROM Clientes cli, Publicaciones pub, Compras com, RubroPublicacion rub
WHERE rub.descripcion_corta = @rubro
AND rub.cod_publicacion = pub.cod_publicacion
AND pub.cod_publicacion = com.cod_publicacion
AND com.cod_usuario = cli.cod_usuario
GROUP BY cli.cod_usuario
END
GO;
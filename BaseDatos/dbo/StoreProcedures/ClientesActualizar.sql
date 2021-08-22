CREATE PROCEDURE [dbo].ClientesActualizar
	@ClientesId INT,
	@NombreCompleto VARCHAR(250),
	@Direccion VARCHAR(500),
	@Telefono VARCHAR(500),
	@Estado BIT
AS BEGIN
SET NOCOUNT ON

	BEGIN TRANSACTION TRASA

	BEGIN TRY

		
UPDATE dbo.Clientes SET
		  NombreCompleto=@NombreCompleto,
		  Direccion=@Direccion,
		  Telefono=@Telefono,
		  Estado=@Estado

	WHERE ClientesId=@ClientesId

		COMMIT TRANSACTION TRASA
		
		SELECT 0 AS CodeError, '' AS MsgError



	END TRY

	BEGIN CATCH
		SELECT 
				ERROR_NUMBER() AS CodeError
			,	ERROR_MESSAGE() AS MsgError

			ROLLBACK TRANSACTION TRASA
	END CATCH


END
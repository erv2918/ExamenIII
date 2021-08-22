CREATE PROCEDURE [dbo].ClientesInsertar
	@NombreCompleto VARCHAR(250),
	@Direccion VARCHAR(500),
	@Telefono VARCHAR(500),
	@Estado BIT
AS BEGIN
SET NOCOUNT ON

	BEGIN TRANSACTION TRASA

	BEGIN TRY

		
		INSERT INTO dbo.Clientes 
		(	       
		  NombreCompleto,
		  Direccion,
		  Telefono,
		  Estado
		)
		VALUES
		(
		  @NombreCompleto,
		  @Direccion,
		  @Telefono,
		  @Estado
		)


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
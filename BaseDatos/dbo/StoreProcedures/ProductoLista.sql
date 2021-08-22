CREATE PROCEDURE [dbo].[ProductoLista]
AS
	BEGIN
		SET NOCOUNT ON

		SELECT 
		ProductoId,
		Descripcion

		FROM dbo.Producto
		Where Estado=1
	END

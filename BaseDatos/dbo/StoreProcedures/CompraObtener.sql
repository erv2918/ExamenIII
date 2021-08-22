CREATE PROCEDURE [dbo].[CompraObtener]
	@IdCompra INT= null
AS
	begin
	SET NOCOUNT ON


	 SELECT
	    CP.IdCompra,
		CP.ProductoId,
		CP.FechaCompra,
		CP.Monto,
		CP.Impuesto,
		CP.Total ,
		CP.Observaciones,
		CP.Estado,

		CL.ClientesId,
		CL.NombreCompleto,

		P.ProductoId,
		P.Descripcion

	 FROM dbo.Compra CP
	 INNER JOIN dbo.Clientes CL
			ON (CP.ClientesId=CL.ClientesId)
		INNER JOIN dbo.Producto P
			ON (CP.ProductoId=P.ProductoId)
	 WHERE

	 (@IdCompra IS NULL OR IdCompra = @IdCompra)



	end

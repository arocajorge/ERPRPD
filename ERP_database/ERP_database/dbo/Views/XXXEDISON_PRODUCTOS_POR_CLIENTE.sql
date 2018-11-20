CREATE VIEW XXXEDISON_PRODUCTOS_POR_CLIENTE
AS
SELECT c.IdEmpresa, c.IdCbteVta, c.vt_NumFactura, c.vt_fecha, cli.IdCliente, per.pe_nombreCompleto, p.IdProducto, p.pr_descripcion, p.lote_num_lote, pre.nom_presentacion, d.vt_cantidad, d.vt_PrecioFinal, 
                  in_categorias.IdCategoria, in_categorias.ca_Categoria, pad.IdProducto IdProductoPadre, pad.pr_descripcion as ProductoPadre
FROM     in_categorias RIGHT OUTER JOIN
                  in_presentacion AS pre INNER JOIN
                  in_Producto AS p ON pre.IdEmpresa = p.IdEmpresa AND pre.IdPresentacion = p.IdPresentacion ON in_categorias.IdEmpresa = p.IdEmpresa AND in_categorias.IdCategoria = p.IdCategoria RIGHT OUTER JOIN
                  tb_persona AS per INNER JOIN
                  fa_factura AS c INNER JOIN
                  fa_cliente AS cli ON c.IdEmpresa = cli.IdEmpresa AND c.IdCliente = cli.IdCliente ON per.IdPersona = cli.IdPersona LEFT OUTER JOIN
                  fa_factura_det AS d ON c.IdEmpresa = d.IdEmpresa AND c.IdSucursal = d.IdSucursal AND c.IdBodega = d.IdBodega AND c.IdCbteVta = d.IdCbteVta ON p.IdEmpresa = d.IdEmpresa AND p.IdProducto = d.IdProducto
				  left outer join in_Producto as pad on pad.IdEmpresa = p.IdEmpresa and pad.IdProducto = p.IdProducto_padre
WHERE  (c.Estado = 'A') --and pad.IdProducto = 67 
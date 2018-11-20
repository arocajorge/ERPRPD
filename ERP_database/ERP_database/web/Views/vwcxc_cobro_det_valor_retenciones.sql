CREATE VIEW web.vwcxc_cobro_det_valor_retenciones
AS
SELECT IdEmpresa, IdSucursal, IdBodega_Cbte, IdCbte_vta_nota, dc_TipoDocumento, SUM(ValorRteFTE) AS ValorRteFTE, SUM(ValorRteIVA) AS ValorRteIVA, MAX(PorcentajeRetFTE) AS PorcentajeRetFTE, MAX(PorcentajeRetIVA) 
                  AS PorcentajeRetIVA, MAX(cr_fecha) AS cr_fecha, SUM(ValorRteFTE) + SUM(ValorRteIVA) AS TotalRTE
FROM     (SELECT dbo.cxc_cobro_det.IdEmpresa, dbo.cxc_cobro_det.IdSucursal, dbo.cxc_cobro_det.IdBodega_Cbte, dbo.cxc_cobro_det.IdCbte_vta_nota, dbo.cxc_cobro_det.dc_TipoDocumento, 0 AS ValorRteFTE, 
                                    SUM(dbo.cxc_cobro_det.dc_ValorPago) AS ValorRteIVA, 'N' AS ESRetenFTE, dbo.cxc_cobro_tipo.ESRetenIVA, dbo.cxc_cobro.cr_fecha, 0 AS PorcentajeRetFTE, dbo.cxc_cobro_tipo.PorcentajeRet AS PorcentajeRetIVA
                  FROM      dbo.cxc_cobro_det INNER JOIN
                                    dbo.cxc_cobro_tipo ON dbo.cxc_cobro_det.IdCobro_tipo = dbo.cxc_cobro_tipo.IdCobro_tipo INNER JOIN
                                    dbo.cxc_cobro_tipo_motivo ON dbo.cxc_cobro_tipo.IdMotivo_tipo_cobro = dbo.cxc_cobro_tipo_motivo.IdMotivo_tipo_cobro INNER JOIN
                                    dbo.cxc_cobro ON dbo.cxc_cobro_det.IdEmpresa = dbo.cxc_cobro.IdEmpresa AND dbo.cxc_cobro_det.IdSucursal = dbo.cxc_cobro.IdSucursal AND dbo.cxc_cobro_det.IdCobro = dbo.cxc_cobro.IdCobro
                  WHERE   (dbo.cxc_cobro_tipo.ESRetenIVA = 'S') AND (dbo.cxc_cobro.cr_estado = 'A')
                  GROUP BY dbo.cxc_cobro_det.IdEmpresa, dbo.cxc_cobro_det.IdSucursal, dbo.cxc_cobro_det.IdBodega_Cbte, dbo.cxc_cobro_det.IdCbte_vta_nota, dbo.cxc_cobro_det.dc_TipoDocumento, dbo.cxc_cobro_tipo.ESRetenIVA, 
                                    dbo.cxc_cobro.cr_fecha, dbo.cxc_cobro_tipo.PorcentajeRet
                  UNION ALL
                  SELECT cxc_cobro_det_1.IdEmpresa, cxc_cobro_det_1.IdSucursal, cxc_cobro_det_1.IdBodega_Cbte, cxc_cobro_det_1.IdCbte_vta_nota, cxc_cobro_det_1.dc_TipoDocumento, SUM(cxc_cobro_det_1.dc_ValorPago) AS ValorRteFTE, 
                                    0 AS Expr1, cxc_cobro_tipo_1.ESRetenFTE, 'N' AS ESRetenIVA, cxc_cobro_1.cr_fecha, cxc_cobro_tipo_1.PorcentajeRet AS PorcentajeRetFTE, 0 AS Expr2
                  FROM     dbo.cxc_cobro_det AS cxc_cobro_det_1 INNER JOIN
                                    dbo.cxc_cobro_tipo AS cxc_cobro_tipo_1 ON cxc_cobro_det_1.IdCobro_tipo = cxc_cobro_tipo_1.IdCobro_tipo INNER JOIN
                                    dbo.cxc_cobro_tipo_motivo AS cxc_cobro_tipo_motivo_1 ON cxc_cobro_tipo_1.IdMotivo_tipo_cobro = cxc_cobro_tipo_motivo_1.IdMotivo_tipo_cobro INNER JOIN
                                    dbo.cxc_cobro AS cxc_cobro_1 ON cxc_cobro_det_1.IdEmpresa = cxc_cobro_1.IdEmpresa AND cxc_cobro_det_1.IdSucursal = cxc_cobro_1.IdSucursal AND cxc_cobro_det_1.IdCobro = cxc_cobro_1.IdCobro
                  WHERE  (cxc_cobro_tipo_1.ESRetenFTE = 'S') AND (cxc_cobro_1.cr_estado = 'A')
                  GROUP BY cxc_cobro_det_1.IdEmpresa, cxc_cobro_det_1.IdSucursal, cxc_cobro_det_1.IdBodega_Cbte, cxc_cobro_det_1.IdCbte_vta_nota, cxc_cobro_det_1.dc_TipoDocumento, cxc_cobro_tipo_1.ESRetenFTE, cxc_cobro_1.cr_fecha, 
                                    cxc_cobro_tipo_1.PorcentajeRet) AS RET
GROUP BY IdEmpresa, IdSucursal, IdBodega_Cbte, IdCbte_vta_nota, dc_TipoDocumento
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 1, @level0type = N'SCHEMA', @level0name = N'web', @level1type = N'VIEW', @level1name = N'vwcxc_cobro_det_valor_retenciones';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "RET"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 170
               Right = 289
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 12
         Column = 1440
         Alias = 900
         Table = 1176
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1356
         SortOrder = 1416
         GroupBy = 1350
         Filter = 1356
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
', @level0type = N'SCHEMA', @level0name = N'web', @level1type = N'VIEW', @level1name = N'vwcxc_cobro_det_valor_retenciones';


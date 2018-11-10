﻿CREATE TABLE [dbo].[imp_orden_compra_ext] (
    [IdEmpresa]                    INT           NOT NULL,
    [IdOrdenCompra_ext]            DECIMAL (18)  NOT NULL,
    [IdProveedor]                  NUMERIC (18)  NOT NULL,
    [IdPais_origen]                VARCHAR (10)  NOT NULL,
    [IdPais_embarque]              VARCHAR (10)  NOT NULL,
    [IdCiudad_destino]             VARCHAR (25)  NOT NULL,
    [IdCatalogo_via]               INT           NOT NULL,
    [IdCatalogo_forma_pago]        INT           NOT NULL,
    [oe_fecha]                     DATETIME      NOT NULL,
    [oe_fecha_llegada_est]         DATETIME      NULL,
    [oe_fecha_embarque_est]        DATETIME      NULL,
    [oe_fecha_desaduanizacion_est] DATETIME      NULL,
    [IdCtaCble_importacion]        VARCHAR (20)  NOT NULL,
    [oe_observacion]               VARCHAR (max) NULL,
    [oe_codigo]                    VARCHAR (30)  NULL,
    [estado]                       BIT           NOT NULL,
    [IdUsuario_creacion]           VARCHAR (20)  NULL,
    [fecha_creacion]               DATETIME      NULL,
    [IdUsuario_modificacion]       VARCHAR (20)  NULL,
    [fecha_modificacion]           DATETIME      NULL,
    [IdUsuario_anulacion]          VARCHAR (20)  NULL,
    [fecha_anulacion]              DATETIME      NULL,
    [oe_fecha_llegada]             DATETIME      NULL,
    [oe_fecha_embarque]            DATETIME      NULL,
    [oe_fecha_desaduanizacion]     DATETIME      NULL,
    [IdMoneda_origen]              INT           NULL,
    [IdMoneda_destino]             INT           NULL,
    [Estado_cierre]                BIT           NOT NULL,
    CONSTRAINT [PK_imp_orden_compra_ext] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdOrdenCompra_ext] ASC),
    CONSTRAINT [FK_imp_orden_compra_ext_cp_proveedor1] FOREIGN KEY ([IdEmpresa], [IdProveedor]) REFERENCES [dbo].[cp_proveedor] ([IdEmpresa], [IdProveedor]),
    CONSTRAINT [FK_imp_orden_compra_ext_ct_plancta1] FOREIGN KEY ([IdEmpresa], [IdCtaCble_importacion]) REFERENCES [dbo].[ct_plancta] ([IdEmpresa], [IdCtaCble]),
    CONSTRAINT [FK_imp_orden_compra_ext_imp_catalogo] FOREIGN KEY ([IdCatalogo_via]) REFERENCES [dbo].[imp_catalogo] ([IdCatalogo]),
    CONSTRAINT [FK_imp_orden_compra_ext_imp_catalogo1] FOREIGN KEY ([IdCatalogo_forma_pago]) REFERENCES [dbo].[imp_catalogo] ([IdCatalogo]),
    CONSTRAINT [FK_imp_orden_compra_ext_tb_ciudad] FOREIGN KEY ([IdCiudad_destino]) REFERENCES [dbo].[tb_ciudad] ([IdCiudad]),
    CONSTRAINT [FK_imp_orden_compra_ext_tb_moneda] FOREIGN KEY ([IdMoneda_origen]) REFERENCES [dbo].[tb_moneda] ([IdMoneda]),
    CONSTRAINT [FK_imp_orden_compra_ext_tb_moneda1] FOREIGN KEY ([IdMoneda_destino]) REFERENCES [dbo].[tb_moneda] ([IdMoneda]),
    CONSTRAINT [FK_imp_orden_compra_ext_tb_pais] FOREIGN KEY ([IdPais_origen]) REFERENCES [dbo].[tb_pais] ([IdPais]),
    CONSTRAINT [FK_imp_orden_compra_ext_tb_pais1] FOREIGN KEY ([IdPais_embarque]) REFERENCES [dbo].[tb_pais] ([IdPais])
);




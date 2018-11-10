﻿CREATE TABLE [dbo].[tb_Calendario] (
    [IdCalendario]     INT           NOT NULL,
    [fecha]            DATE          NOT NULL,
    [NombreFecha]      VARCHAR (30)  NOT NULL,
    [NombreCortoFecha] VARCHAR (10)  NOT NULL,
    [dia_x_semana]     INT           NULL,
    [dia_x_mes]        INT           NULL,
    [Inicial_del_Dia]  CHAR (2)      NULL,
    [NombreDia]        VARCHAR (20)  NULL,
    [Mes_x_anio]       INT           NULL,
    [NombreMes]        VARCHAR (30)  NULL,
    [IdMes]            INT           NULL,
    [NombreCortoMes]   VARCHAR (15)  NULL,
    [AnioFiscal]       INT           NULL,
    [Semana_x_anio]    INT           NULL,
    [NombreSemana]     VARCHAR (25)  NULL,
    [IdSemana]         INT           NULL,
    [Trimestre_x_Anio] INT           NULL,
    [NombreTrimestre]  VARCHAR (20)  NULL,
    [IdTrimestre]      INT           NULL,
    [IdPeriodo]        VARCHAR (20)  NULL,
    [EsFeriado]        CHAR (1)      NULL,
    [Descripcion]      VARCHAR (200) NULL,
    CONSTRAINT [PK_tb_Calendario] PRIMARY KEY CLUSTERED ([IdCalendario] ASC)
);

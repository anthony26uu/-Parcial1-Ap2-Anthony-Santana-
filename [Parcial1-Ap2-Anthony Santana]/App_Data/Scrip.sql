CREATE TABLE Presupuestos  (
    PresupuestoId INT IDENTITY (1, 1) NOT NULL,
    Fecha           DATETIME NULL,
    Monto        DECIMAL NULL,
	Descripcion VARCHAR (80),
    PRIMARY KEY CLUSTERED (PresupuestoId ASC)
);

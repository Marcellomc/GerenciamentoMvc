Use [Gerencia_OLTP]
GO

Create Table TblUsuarios(
		idUsuario Int IDENTITY Not Null,
		nome Varchar(50),
		usuario Varchar(50),
		senha Varchar(50)
)
Go

Alter Table TblUsuarios
	Add Constraint PKUsuario
	Primary Key(idUsuario)

	Go

Select * From INFORMATION_SCHEMA.TABLE_CONSTRAINTS
gO

Select * From Sys.columns
Where object_id = OBJECT_ID('TblUsuarios')
Go


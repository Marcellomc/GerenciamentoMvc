

Use Gerencia_OLTP
Go

CREATE TABLE tblTelefoneCli(
	IdTelefone INT IDENTITY,
	Tipo Char(4),
	Numero Varchar(20),	
	Id_Cli INT
)
GO

Alter Table tblTelefoneCli
Add Constraint Pk_Telefone
Primary Key(IdTelefone)
Go

Alter Table tblTelefoneCli
Add Constraint Fk_Telefone_Cliente
Foreign Key(Id_Cli)
References tblCliente(IdCli)
Go 


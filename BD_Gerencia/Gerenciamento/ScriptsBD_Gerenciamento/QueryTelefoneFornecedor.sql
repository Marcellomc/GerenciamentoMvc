Use Gerencia_OLTP
Go

CREATE TABLE tblTelefoneFornece(
	IdTelefone INT IDENTITY,
	Tipo Char(4),
	Numero Varchar(20),	
	Id_Fornecedor INT
)
GO

Alter Table tblTelefoneFornece
Add Constraint Pk_TelefoneFornecedor
Primary Key(IdTelefone)
Go

Alter Table tblTelefoneFornece
Add Constraint Fk_Telefone_Fornecedor
Foreign Key(Id_Fornecedor)
References tblFornecedor(IdFornecedor)
Go 
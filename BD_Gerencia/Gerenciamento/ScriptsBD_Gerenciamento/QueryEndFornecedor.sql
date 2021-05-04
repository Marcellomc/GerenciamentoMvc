Use Gerencia_OLTP
Go

CREATE TABLE tblEndFornecedor(
	IdEndereco INT IDENTITY,
	Rua VARCHAR(80),
	Cidade Varchar(50),
	Bairro VARCHAR(50),
	Estado Char(2),
	Id_Fornecedor INT unique
)
GO


Alter Table tblEndFornecedor
Add Constraint Pk_EnderecoFornecedor
Primary Key(IdEndereco)
Go



Alter Table tblEndFornecedor
Add Constraint Fk_Endereco_Fornecedor
Foreign Key(Id_Fornecedor)
References tblFornecedor(IdFornecedor)
Go

SELECT * FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS
GO

Drop Table tblEndFornecedor
Go


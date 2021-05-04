/* 
Select Nome, Sexo, Email = Projeção
From Cliente = Origem
Where Sexo = 'F' = Seleção
*/

Use Gerencia_OLTP
Go

CREATE TABLE tblEndereco(
	IdEndereco INT IDENTITY,
	Rua VARCHAR(80),
	Cidade Varchar(50),
	Bairro VARCHAR(50),
	Estado Char(2),
	Id_Cliente INT Unique
)
GO


Alter Table tblEndereco
Add Constraint Pk_Endereco
Primary Key(IdEndereco)
Go


Alter Table tblEndereco
Add Constraint Fk_Endereco_Cliente
Foreign Key(Id_Cliente)
References tblCliente(IdCli)
Go



SELECT * FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS
GO

Drop Table tblEndereco
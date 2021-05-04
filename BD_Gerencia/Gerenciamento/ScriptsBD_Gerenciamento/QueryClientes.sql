Use Gerencia_OLTP
Go

Create Table tblCliente(
		
		idCli Int Identity,
		nomeCli Varchar(50) Not Null,
		cpfCnpjCli Varchar(20)Not Null,
		sexoCli Char(1),
		emailCli Varchar(30)
)
Go


Alter Table tblCliente
Add Constraint PK_Cliente
Primary Key(idCli)
Go


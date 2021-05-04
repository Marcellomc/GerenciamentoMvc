
Use Gerencia_OLTP
Go

Create Table tblFornecedor(
		
		idFornecedor Int Identity,
		nome Varchar(50) Not Null,
		cpfCnp Varchar(20)Not Null,
		sexo Char(1),
		email Varchar(30)
)
Go


Alter Table tblFornecedor
Add Constraint PK_Fornecedor
Primary Key(idFornecedor)
Go


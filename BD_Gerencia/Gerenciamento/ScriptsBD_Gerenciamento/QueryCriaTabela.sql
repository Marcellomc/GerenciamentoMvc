
--Script de Cria��o de tabela com constrint por fora

CREATE TABLE ENDERECO(
	IDENDERECO INT IDENTITY,
	RUA VARCHAR(50),
	BAIRRO VARCHAR(50),
	ID_CLIENTE INT
)
GO

-- ALTER TABLE

ALTER TABLE ENDERECO
ADD CONSTRAINT PK_ENDERECO
PRIMARY KEY(IDENDERECO)
GO

ALTER TABLE ENDERECO
ADD CONSTRAINT FK_ENDERECO_CLIENTE
FOREIGN KEY(ID_CLIENTE)
REFERENCES CLIENTE(IDCLIENTE)
GO




SELECT * FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS
GO
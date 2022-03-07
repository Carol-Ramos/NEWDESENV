CREATE DATABASE NewDesenv
USE NewDesenv

CREATE TABLE Cliente
(
	Id_Cliente int NOT NULL PRIMARY KEY IDENTITY,
	Nome VARCHAR (MAX) NOT NULL,
	Sobrenome VARCHAR (MAX) NOT NULL,
	CPF VARCHAR (20) UNIQUE NOT NULL,
)

SELECT * 
	FROM Cliente

INSERT INTO Cliente (Nome, Sobrenome, CPF)
	VALUES  ('Soraia', 'Moraes', '111.222.333-00'),
			('Rafaela', 'Braga', '222.333.444-11'),
			('Miguel', 'Silva', '333.444.555-22'),
			('Alice', 'Cabral', '444.555.666-33');



CREATE TABLE Fornecedor
(
	Id_Fornecedor INT NOT NULL PRIMARY KEY IDENTITY,
	CNPJ VARCHAR(30) UNIQUE NOT NULL,
	Nome_Fornecedor VARCHAR(30)
);	

INSERT INTO Fornecedor (CNPJ, Nome_Fornecedor)
	VALUES  ('11.222.333/4 555-66', 'Azul'),
			('22.333.444/5 666-77', 'Rosa'),
			('33.444.555/6 777-88', 'Vermelho'),
			('44.555.666/7 888-99', 'Roxo'),
			('55.666.777/8 999-00', 'Preto'),
			('66.777.888/9 000-11', 'Castanho');

SELECT *
	FROM Fornecedor

CREATE TABLE Produto
(
	Id_Produto INT NOT NULL PRIMARY KEY IDENTITY,
	Id_Fornecedor INT NOT NULL,
	Nome_Produto VARCHAR (30),
	CONSTRAINT fk_FornProd FOREIGN KEY (Id_Fornecedor) REFERENCES Fornecedor(Id_Fornecedor)
);

INSERT INTO Produto (Id_Fornecedor, Nome_Produto)
	VALUES  ('1', 'Apontador'),
			('1', 'Borracha'),
			('1', 'Caneta'),
			('2', 'Bússula'),
			('3', 'Capacete');		

	UPDATE Produto 
	SET Nome_Produto = 'E'
	WHERE Nome_Produto = '';

	SELECT *
	FROM Produto

CREATE TABLE Vendedor
(
	Id_Vendedor INT NOT NULL PRIMARY KEY IDENTITY,
	Id_Produto INT,
	Nome_Vendedor VARCHAR (MAX),
	CONSTRAINT fk_VendProd FOREIGN KEY (Id_Produto) REFERENCES Produto (Id_Produto)
)

INSERT INTO Vendedor (Id_Produto, Nome_Vendedor)
	VALUES  ('5', 'Marina'),
			('6', 'Jefferson'),
			('4', 'Lucas'),
			('3', 'Nauane'),
			('2', 'Milena');

SELECT * 
	FROM Vendedor


CREATE TABLE Nota_Fiscal
(
	Id INT NOT NULL PRIMARY KEY IDENTITY,
	Id_Fornecedor INTEGER,
	Id_Cliente INTEGER,
	Id_Produto INTEGER,
	Id_Vendedor INTEGER,
	CONSTRAINT fk_FornNota FOREIGN KEY (Id_Fornecedor) REFERENCES Fornecedor (Id_Fornecedor),
	CONSTRAINT fk_ProdNota FOREIGN KEY (Id_Produto) REFERENCES Produto (Id_Produto),
	CONSTRAINT fk_CliNota FOREIGN KEY (Id_Cliente) REFERENCES Cliente (Id_Cliente),
	CONSTRAINT fk_VendNota FOREIGN KEY (Id_Vendedor) REFERENCES Vendedor (Id_Vendedor)
);

INSERT INTO Nota_Fiscal (Id_Fornecedor, Id_Cliente, Id_Produto, Id_Vendedor)
	VALUES  ('2', '3', '6', '5'),
			('3', '2', '3', '3'),
			('1', '1', '5', '1');

SELECT *
	FROM Nota_Fiscal
	

------------------> PROCEDURES

CREATE PROCEDURE BuscaFornecedor
	@NomeFornecedor VARCHAR(20)
AS

SET @NOMEFORNECEDOR = '%' + @NomeFornecedor + '%';

SELECT Fornecedor.Nome_Fornecedor, Produto.Nome_Produto
	FROM Fornecedor

	INNER JOIN Produto ON Produto.Id_Fornecedor = Fornecedor.Id_Fornecedor

	WHERE Fornecedor.Nome_Fornecedor like @NomeFornecedor;

EXEC BuscaFornecedor 'Azul';
EXEC BuscaFornecedor '%';

---------------------------------------------------------------------

CREATE PROCEDURE IncluirNovoCliente
	@NomeCliente VARCHAR(MAX)
AS
BEGIN
	DECLARE @idCliente INT

	SELECT Id_Cliente  = MAX(@idCliente) + 1, Nome FROM Cliente

	INSERT INTO Cliente (Id_Cliente, Nome)
		VALUES (@idCliente, @NomeCliente)

	SELECT @idCliente = Id_Cliente FROM Cliente WHERE Id_Cliente = @idCliente;
	SELECT @idCliente AS retorno;

	END;
	GO

	EXEC IncluirNovoCliente 'Mirella';
	EXEC IncluirNovoCliente 'Miguel';
	SELECT *
		FROM Cliente


--Criando o banco de dados

CREATE DATABASE SoSimple;

--Criando as tabelas

USE SoSimple

CREATE TABLE TCLIE (

	idCliente	smallint	identity
	CONSTRAINT	PK_TCLIE_IdCliente
	PRIMARY KEY (idCliente),
	
	nomeCliente	varchar(50),
	
	cpfCliente	varchar(15)
	CONSTRAINT UN_TCLIE_cpfCliente
	UNIQUE (cpfCliente),

	telCliente	varchar(15),

	cepCliente varchar(10),

	endCliente varchar(50),

	numEndCliente varchar(6),

	cidCliente varchar(25),

	ufCliente varchar(25)
);

CREATE TABLE TPROD (

	idProduto smallint identity
	CONSTRAINT PK_TPROD_idProduto
	PRIMARY KEY (idProduto),

	tipoProduto varchar(20),

	modeloProduto varchar(20),

	marcaProduto varchar(20),

	numSerie varchar(15)
);

CREATE TABLE TPECA (

	idProduto smallint
	CONSTRAINT PK_TPECA_idProduto
	FOREIGN KEY (idProduto)
	REFERENCES TPROD(idProduto),

	nomePeca varchar(30),

	qtdPeca smallint
);

CREATE TABLE TFUNC (
	
	idFunc smallint identity
	CONSTRAINT PK_TFUNC_idFunc
	PRIMARY KEY (idFunc),

	nomeFunc varchar(50),
	
	loginFunc varchar(10),

	senhaFunc varchar(15),

	deptFunc varchar(20)
);
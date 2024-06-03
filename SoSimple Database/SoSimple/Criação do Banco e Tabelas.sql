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
);

CREATE TABLE TPECA (
	
	idPeca smallint identity
	CONSTRAINT PK_TPECA_idPeca
	PRIMARY KEY (idPeca),

	idProduto smallint
	CONSTRAINT FK_TPECA_idProduto
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

CREATE TABLE TORDE (

	OS	smallint identity
	CONSTRAINT PK_TORDE_OS
	PRIMARY KEY (OS),

	idClienteOS	smallint
	CONSTRAINT FK_TORDE_idClienteOS
	FOREIGN KEY (idClienteOS)
	REFERENCES TCLIE(idCliente),

	idProdutoOS smallint
	CONSTRAINT FK_TORDE_idProdutoOS
	FOREIGN KEY (idProdutoOS)
	REFERENCES TPROD(idProduto),

	aparenciaProd varchar(80),

	numSerieProd varchar(20),

	descDefeitoProd varchar(80),

	statusOS varchar(20)
);

CREATE TABLE TSLTP (

	idSolicitacao	smallint identity
	CONSTRAINT PK_TSLTP_idSolicitacao
	PRIMARY KEY (idSolicitacao),

	osSolicitante	smallint
	CONSTRAINT FK_TSLTP_osSolicitante
	FOREIGN KEY (osSolicitante)
	REFERENCES TORDE(OS),

	idPecaSolicitada smallint
	CONSTRAINT FK_TSLTP_idPecaSolicitada
	FOREIGN KEY (idPecaSolicitada)
	REFERENCES TPECA(idPeca),

	qtdPecaSolicitadas	smallint
);
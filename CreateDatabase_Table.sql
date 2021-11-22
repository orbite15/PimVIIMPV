CREATE DATABASE db_pessoa;

drop table db_pessoa.tb_telefone;
DROP TABLE 	db_pessoa.tb_telefone_tipo;
DROP TABLE 	db_pessoa.tb_pessoa_telefone;
DROP TABLE 	db_pessoa.tb_pessoa;
DROP TABLE 	db_pessoa.tb_endereco;

CREATE TABLE db_pessoa.tb_pessoa(
    ID int  NOT NULL AUTO_INCREMENT,
    nome varchar(256),
    cpf bigint,
    FK_id_end int,
    CONSTRAINT PK_pessoa PRIMARY KEY (ID)
);

CREATE TABLE db_pessoa.tb_endereco(
    ID int  NOT NULL AUTO_INCREMENT,
    logradouro varchar(256),
    numero int,
    cep int,
    bairro varchar(50),
	cidade varchar(30),
	estado varchar(20),
    CONSTRAINT PK_end PRIMARY KEY (ID)
);

ALTER TABLE db_pessoa.tb_pessoa ADD CONSTRAINT fk_pessoa_end FOREIGN KEY (FK_id_end) REFERENCES db_pessoa.tb_endereco(ID);

CREATE TABLE db_pessoa.tb_pessoa_telefone(
    FK_ID_pessoa int,
    FK_ID_telefone int,
    CONSTRAINT PK_pessoa_tel PRIMARY KEY (FK_ID_pessoa, FK_ID_telefone)
);

ALTER TABLE db_pessoa.tb_pessoa_telefone ADD CONSTRAINT fk_pessoatel_pessoa FOREIGN KEY (FK_ID_pessoa) REFERENCES db_pessoa.tb_pessoa (ID);
ALTER TABLE db_pessoa.tb_pessoa_telefone ADD CONSTRAINT fk_pessoatel_telefone FOREIGN KEY (FK_ID_telefone) REFERENCES db_pessoa.tb_telefone (ID);

CREATE TABLE db_pessoa.tb_telefone(
    ID int  NOT NULL AUTO_INCREMENT,
    numero  int,
    DDD  int,
    FK_id_tipo  int,
    CONSTRAINT PK_telefone PRIMARY KEY (ID)
);

CREATE TABLE db_pessoa.tb_telefone_tipo(
    ID int  NOT NULL AUTO_INCREMENT,
    tipo  varchar(10),
    CONSTRAINT PK_telefone_tipo PRIMARY KEY (ID)
);

ALTER TABLE db_pessoa.tb_telefone ADD CONSTRAINT fk_teltipo_tel FOREIGN KEY (FK_id_tipo) REFERENCES db_pessoa.tb_telefone_tipo (ID);
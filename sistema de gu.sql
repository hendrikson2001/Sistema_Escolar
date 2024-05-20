CREATE DATABASE SYSTEM_MU
use SYSTEM_MU

CREATE TABLE tbl_anos_letivos (
    ano_letivo_id INT PRIMARY KEY IDENTITY,
    ano_inicio INT NOT NULL,
    ano_fim INT NOT NULL
);

CREATE TABLE tbl_anos_curriculares (
    ano_curricular_id INT PRIMARY KEY IDENTITY,
    ano INT NOT NULL
);

CREATE TABLE tbl_departamentos (
    departamento_id INT PRIMARY KEY IDENTITY,
    nome_departamento VARCHAR(100) NOT NULL
);

CREATE TABLE tbl_licenciaturas (
    licenciaturas_id INT PRIMARY KEY IDENTITY,
    nome_licenciaturas VARCHAR(100) NOT NULL,
    departamento_id INT,
	descricao TEXT NOT NULL,
    duracao INT NOT NULL,
    FOREIGN KEY (departamento_id) REFERENCES tbl_departamentos(departamento_id)
);

CREATE TABLE tbl_estudantes (
	estudante_id INT PRIMARY KEY IDENTITY,
    primeiro_nome VARCHAR(50) NOT NULL,
    ultimo_nome VARCHAR(50) NOT NULL,
	numero_bi VARCHAR(15) UNIQUE,
	numero_passaport VARCHAR(15) UNIQUE,
	nacionalidade VARCHAR(100) NOT NULL,
	genero VARCHAR(15) NOT NULL,
    data_nascimento DATE,
    email VARCHAR(100) UNIQUE,
);

CREATE TABLE tbl_funcionarios (
    funcionario_id INT PRIMARY KEY IDENTITY,
    primeiro_nome VARCHAR(50) NOT NULL,
    ultimo_nome VARCHAR(50) NOT NULL,
	numero_bi VARCHAR(15) NOT NULL UNIQUE,
	numero_passport VARCHAR(15) UNIQUE,
    data_nascimento DATE,
	genero VARCHAR(15) NOT NULL,
    email VARCHAR(100) UNIQUE,
    data_contratacao DATE,
    departamento_id INT,
    salario DECIMAL(10, 2),
    FOREIGN KEY (departamento_id) REFERENCES tbl_departamentos(departamento_id)
);

CREATE TABLE tbl_professores (
    professor_id INT PRIMARY KEY IDENTITY,
    funcionario_id INT,
    FOREIGN KEY (funcionario_id) REFERENCES tbl_funcionarios(funcionario_id)
);

CREATE TABLE tbl_telefones (
    telefone_id INT PRIMARY KEY IDENTITY,
    numero_telefone VARCHAR(20),
    estudante_id INT,
	funcionario_id INT,
	FOREIGN KEY (estudante_id) REFERENCES tbl_estudantes(estudante_id) ON DELETE CASCADE,
	FOREIGN KEY (funcionario_id) REFERENCES tbl_funcionarios(funcionario_id) ON DELETE CASCADE
);

CREATE TABLE tbl_enderecos (
    telefone_id INT PRIMARY KEY IDENTITY,
    rua VARCHAR(100),
	bairro VARCHAR(100),
	municipio VARCHAR(100),
    estudante_id INT,
	funcionario_id INT,
	FOREIGN KEY (estudante_id) REFERENCES tbl_estudantes(estudante_id) ON DELETE CASCADE,
	FOREIGN KEY (funcionario_id) REFERENCES tbl_funcionarios(funcionario_id) ON DELETE CASCADE
);
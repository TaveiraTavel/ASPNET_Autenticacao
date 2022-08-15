create database dbautenticacao;
use dbautenticacao;

create table usuario(
	UsuarioID int primary key,
    Nome varchar(100) unique not null,
    Login varchar(50) unique not null,
    Senha varchar(100) not null
);
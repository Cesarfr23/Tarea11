create DataBase Peliculas;
go

use Peliculas;
go

create table Categoria
(
	CategoriaId int primary key identity(1,1),
	Descripcion varchar(50)
)
go

create table Pelicula
(
	PeliculaId int primary key identity(1,1),
	Titulo varchar(40),
	Signosis varchar(100),
	Calificacion int,
	Anno int,
	Idioma varchar(20),
	Genero varchar(20),
	CategoriaId int References Categoria (CategoriaId)
)
go
Create Database Tienda
Use Tienda


Create table EstadosClientes
(
	EdoClienteId int primary key identity,
	Estado varchar(80)
);

Create table Clientes
(
	ClienteId int primary key identity,
	Nombre varchar(80),
	Edad int,
	EdoClienteId int,
	foreign key (EdoClienteId) references EstadosClientes(EdoClienteId),
);

Create table Pagos
(
	PagoId int primary key identity,
	ClienteId int,
	FechaPago date,
	Total int,
	TipoPago varchar(80),
	IVA int
	foreign key (ClienteId) references Clientes(ClienteId)
);
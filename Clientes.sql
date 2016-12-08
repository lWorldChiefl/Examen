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

Insert into EstadosClientes Values ('Activo')
Insert into EstadosClientes Values ('Desactivado')

SELECT * FROM EstadosClientes

Insert into Clientes values ('Juan',18,1)
Insert into Clientes values ('Maria',21,2)
Insert into Clientes values ('Joselyn',33,1)
Insert into Clientes values ('Miguel',2,2)

SELECT * FROM Clientes

Insert into Pagos values (1,GETDATE(),18,'Dolar',5)
Insert into Pagos values (1,GETDATE(),100,'Dolar',5)
Insert into Pagos values (4,GETDATE(),10,'Euro',10)


SELECT * FROM Pagos
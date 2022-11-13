﻿use master
go 
drop database if exists FStoreDB
go
create database FStoreDB 
go
use FStoreDB
go

create table Member (
    MemberId int primary key not null identity(1,1),
    Email varchar(100) not null,
    CompanyName varchar(40) not null,
    City varchar(15) not null,
    Country varchar(15) not null,
    Password varchar(30) not null
)

create table Product (
    ProductId int primary key not null identity(1,1),
    CategoryId int not null,
    ProductName varchar(40) not null,
    Weight varchar(20) not null,
    UnitPrice money not null,
    UnitsInStock int not null
)

create table [Order] (
    OrderId int primary key not null identity(1, 1),
    MemberId int not null foreign key references Member(MemberId),
    OrderDate datetime not null,
    RequiredDate datetime not null,
    ShippedDate datetime not null,
    Freight money not null
)

create table OrderDetails (
    OrderId int not null foreign key references [Order](OrderId),
    ProductId int not null foreign key references Product(ProductId),
    UnitPrice money not null,
    Quantity int not null,
    Discount float not null
    constraint PK_OrderDetails primary key (OrderId, ProductId)
)
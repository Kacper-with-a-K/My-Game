\sql

"create database"
CREATE DATABASE newspaperSystem;

"use databse"
USE newspaperSystem;

"create the customer table"
CREATE TABLE Customer(id int, FirstName varchar(255), LastName varchar(255), Address varchar(255), PhoneNumber int, Eircode varchar(255), DeliveryDays varchar(255), Email varchar(255));

"check if it exists and if all columns exist"
DESCRIBE Customer;

"create the order table"
CREATE TABLE Orders(id int, Address varchar(255), Publications varchar(255));

"check if it exists and if all columns exist"
DESCRIBE Order;

CREATE TABLE 
--setting up this ShoeStore Database

--USE master;
--GO

--DROP DATABASE IF EXISTS ShoeStore;

--CREATE DATABASE ShoeStore;
--GO

--USE ShoeStore;
--GO


--let's start adding in the tables

--BEGIN TRANSACTION;

--CREATE TABLE customer (

--customer_id INT IDENTITY (1,1),
--last_name VARCHAR(50) NOT NULL,
--first_name VARCHAR(50) NOT NULL,
--isMember BIT NOT NULL,

----adding in the primary key stuff right quick 

--CONSTRAINT pk_customer PRIMARY KEY (customer_id)
--);

--CREATE TABLE shoe (

--shoe_id INT IDENTITY (1,1),
--shoe_name VARCHAR(40) NOT NULL,
--manufacturer VARCHAR(45) NOT NULL,
--shoe_type VARCHAR(20) NOT NULL,
--shoe_size INT NOT NULL,
--price DECIMAL(5,2) NOT NULL,
--quantity INT NOT NULL,

--CONSTRAINT pk_shoe PRIMARY KEY (shoe_id)

--);

--CREATE TABLE transactions (

--customer_id INT NOT NULL,
--shoe_id INT NOT NULL,
--date_bought DATETIME NOT NULL,
--isReturn BIT NOT NULL,

--CONSTRAINT pk_transactions PRIMARY KEY (customer_id, shoe_id), 
--CONSTRAINT fk_transactions_customer FOREIGN KEY (customer_id) REFERENCES customer(customer_id),
--CONSTRAINT fk_transactions_shoe FOREIGN KEY (shoe_id) REFERENCES shoe(shoe_id)

--);

--COMMIT;

SELECT * FROM shoe





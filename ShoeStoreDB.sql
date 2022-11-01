----setting up this ShoeStore Database

--USE master;
--GO

--DROP DATABASE IF EXISTS ShoeStore;

--CREATE DATABASE ShoeStore;
--GO

--USE ShoeStore;
--GO


----let's start adding in the tables

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

--SELECT * FROM shoe

--SELECT * FROM customer

--INSERT INTO customer (last_name,first_name,isMember)
--VALUES ('Elliott','Sam', 0), ('Friedmann', 'Sean', 1), ('Brown', 'Eliot', 0), ('Jackson', 'Christian', 0), ('Long', 'Peri',0),('Fayomi', 'Temilolu', 0), ('Garcia','Maria', 0)



--INSERT INTO transactions (customer_id, shoe_id, date_bought, isReturn)
--VALUES (1, 22, '2022-10-21', 0), (1,38, '2021-11-05', 0), (2, 12, '2022-06-20',0), (3,8,'2020-06-11',0),(3,17,'2021-07-16',0),(3,26,'2022-09-12',0),(4,29,'2022-10-18',1),(5,32,'2022-02-22',0),(5,30,'2022-04-20',0),(6,21,'2022-02-16',0),(7,8,'2022-10-02',0)

--SELECT * FROM customer
--JOIN transactions ON customer.customer_id = transactions.customer_id
--JOIN shoe ON transactions.shoe_id = shoe.shoe_id
--WHERE first_name= 'Sam'



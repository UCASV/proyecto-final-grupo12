CREATE DATABASE Vaccination;
USE Vaccination;
SET LANGUAGE 'us_english';

CREATE TABLE CITIZEN(
	dui VARCHAR(10) PRIMARY KEY,
	full_name VARCHAR(50) NOT NULL,
	citizen_address VARCHAR(100) NOT NULL,
	phone_number VARCHAR(9) NOT NULL,
	email VARCHAR(40),
	age INT NOT NULL,
	id_disease INT,
	id_institution INT,
	id_sec_effect INT
	
);

CREATE TABLE INSTITUTION(
	id INT PRIMARY KEY,
	name_institution VARCHAR(30) NOT NULL
);

CREATE TABLE DISEASE(
	id INT PRIMARY KEY,
	illness_name VARCHAR(35) NOT NULL
);

CREATE TABLE CABIN(
	id INT PRIMARY KEY,
	cabin_address VARCHAR(100) NOT NULL,
	cabin_phone VARCHAR(9) NOT NULL,
	employee_in_charge VARCHAR(50) NOT NULL,
	cabin_email VARCHAR(40) NOT NULL,
);

CREATE TABLE APPOINTMENT(
	id_appointment INT PRIMARY KEY IDENTITY,
	id_citizen VARCHAR(10) NOT NULL,
	id_cabin INT NOT NULL,
	date_vaccination1 DATETIME,
	date_vaccination2 DATETIME
	
);

CREATE TABLE EMPLOYEE(
	id INT PRIMARY KEY,
	employee_name VARCHAR(50) NOT NULL,
	institutional_email VARCHAR(40) NOT NULL,
	password_ VARCHAR(20) NOT NULL,
	employee_address VARCHAR(100) NOT NULL,
	id_type INT
);

CREATE TABLE EMPLOYEE_TYPE( 
	id INT PRIMARY KEY,
	type_em VARCHAR(35) NOT NULL
);

CREATE TABLE SIDE_EFFECT(
	id INT PRIMARY KEY,
	secondary_effect VARCHAR(35) NOT NULL
);
CREATE TABLE SESION (
    id INT PRIMARY KEY IDENTITY,
	id_cabin INT,
	id_employee INT,
	date_hour DATETIME
);
--------------FK'S---------------------
--- CITIZEN
ALTER TABLE CITIZEN 
ADD CONSTRAINT FK_CITIZEN_ILLNESS 
FOREIGN KEY (id_disease) REFERENCES DISEASE (id);

ALTER TABLE CITIZEN 
ADD CONSTRAINT FK_CITIZEN_INSTITUTION 
FOREIGN KEY (id_institution) REFERENCES INSTITUTION (id);

ALTER TABLE CITIZEN
ADD CONSTRAINT FK_CITIZEN_SEC_EFFECT
FOREIGN KEY (id_sec_effect) REFERENCES SIDE_EFFECT (id);



--RESERVATION
ALTER TABLE APPOINTMENT
ADD CONSTRAINT FK_RESERVATION_citizen
FOREIGN KEY (id_citizen) REFERENCES CITIZEN (dui);

ALTER TABLE APPOINTMENT
ADD CONSTRAINT FK_RESERVATION_cabin
FOREIGN KEY (id_cabin) REFERENCES CABIN (id);



--EMPLOYEE


ALTER TABLE EMPLOYEE
ADD CONSTRAINT FK_EMPLOYEE_TYPE
FOREIGN KEY (id_type) REFERENCES EMPLOYEE_TYPE (id);

--SESION
ALTER TABLE SESION
ADD CONSTRAINT FK_SESION_CABIN
FOREIGN KEY (id_cabin) REFERENCES CABIN (id);

ALTER TABLE SESION 
ADD CONSTRAINT FK_SESION_EMPLOYEE
FOREIGN KEY (id_employee) REFERENCES EMPLOYEE (id);

------------------ DATA --------------------------

--------- TABLE CABIN
INSERT INTO CABIN VALUES (1,'Blvr. Los Proceres, Antiguo Cuscatlan, San Salvador', '2001-4201', 'Juan Guillermo Rodas', 'Nunc.ut@covid.sv');
INSERT INTO CABIN VALUES (2,'San Juan Opico, La Libertad,', '2021-3242', 'Fernando Antonio Ortega', 'adwee.ut@covid.sv');
INSERT INTO CABIN VALUES (3,'Puerto de la Libertad, La Libertad', '2131-3886', 'Frances Powell', 'adfggr.ut@covid.sv');
INSERT INTO CABIN VALUES (4,'Izalco, Sonsonate', '2245-3462', 'Carolyn Williams', 'SOJws.ut@covid.sv');

--------- TABLE INSTITUTION
INSERT INTO INSTITUTION VALUES (1, 'Ninguno');
INSERT INTO INSTITUTION VALUES (2,'Personal de salud');
INSERT INTO INSTITUTION VALUES (3,'PNC');
INSERT INTO INSTITUTION VALUES (4,'Fuerza Armada');
INSERT INTO INSTITUTION VALUES (5,'Cuerpos de socorro');
INSERT INTO INSTITUTION VALUES (6,'Personal de fronteras');
INSERT INTO INSTITUTION VALUES (7,'Personal de centros penales');
INSERT INTO INSTITUTION VALUES (8,'Personal del gobierno central');

------- TABLE ILLNESS
INSERT INTO DISEASE VALUES (1, 'Ninguno');
INSERT INTO DISEASE VALUES (2,'Alzheimer y demencia');
INSERT INTO DISEASE VALUES (3,'Artritis');
INSERT INTO DISEASE VALUES (4,'Asma');
INSERT INTO DISEASE VALUES (5,'Cancer');
INSERT INTO DISEASE VALUES (6,'Diabetes');
INSERT INTO DISEASE VALUES (7,'Epilepsia');
INSERT INTO DISEASE VALUES (8,'VIH/SIDA');
INSERT INTO DISEASE VALUES (9,'Parkinson');
INSERT INTO DISEASE VALUES (10,'Otro.');

-- TABLE SECONDARY_EFFECTS
INSERT INTO SIDE_EFFECT VALUES (1, 'Ninguno');
INSERT INTO SIDE_EFFECT VALUES (2, 'Dolor de brazo');
INSERT INTO SIDE_EFFECT VALUES (3, 'Dolor de cabeza');
INSERT INTO SIDE_EFFECT VALUES (4, 'Dolor muscular');
INSERT INTO SIDE_EFFECT VALUES (5, 'Enrojecimiento de brazo');
INSERT INTO SIDE_EFFECT VALUES (6, 'Escalofrios');
INSERT INTO SIDE_EFFECT VALUES (7, 'Fiebre');
INSERT INTO SIDE_EFFECT VALUES (8, 'Hinchazon de brazo');
INSERT INTO SIDE_EFFECT VALUES (9, 'Nauseas');

----- TABLE EMPLOYEE_KIND
INSERT INTO EMPLOYEE_TYPE VALUES (1, 'Encargado');
INSERT INTO EMPLOYEE_TYPE VALUES (2, 'Gestor');
INSERT INTO EMPLOYEE_TYPE VALUES (3, 'Vacunador');

----- TABLE EMPLOYEE
INSERT INTO EMPLOYEE VALUES (001, 'Ronaldo Canizales', 'rcanizales@covid.sv', 'Ronaldo1234',' casa numero 6,Bulevar Norte, San Salvador',  2)
INSERT INTO EMPLOYEE VALUES (002, 'Juan Guillermo Rodas', 'jrodas@covid.sv', 'juan2233','casa numero 9,Antiguo Cuscatlan, San Salvador',  1)
INSERT INTO EMPLOYEE VALUES (003, 'Fernando Antonio Ortega', 'fortega@covid.sv', 'fernando3344', 'casa numero 15,San Juan Opico, La Libertad',  1)
INSERT INTO EMPLOYEE VALUES (004, 'Cristian Chinchilla', 'cchinchilla@covid.sv', 'cristian3214', 'casa numero 8,Santa Tecla, La Libertad', 2)
INSERT INTO EMPLOYEE VALUES (005, 'Frances Powell', 'fpowell@covid.sv', 'frances9876', 'casa numero 10,San Salvador,San Salvador',  1)
INSERT INTO EMPLOYEE VALUES (006, 'Rodrigo Molina', 'rmolina@covid.sv', 'rodrigo9630', 'casa numero 8,Soyapango,San Salvador',  2)
INSERT INTO EMPLOYEE VALUES (007, 'Carolyn Williams', 'cwilliams@covid.sv', 'cwilliams147', 'casa numero 50,Izalco,Sonsonate',  1)
INSERT INTO EMPLOYEE VALUES (008, 'Wilmer Hernandez', 'whernandez@covid.sv', 'whernandez8520', 'casa numero 6,Izalco,Sonsonate',  2)
INSERT INTO EMPLOYEE VALUES (009, 'Antonio Casas', 'acasas@covid.sv', 'acasas654', 'casa numero 3,Antiguo Cuscatlan,San Salvador',  3)
INSERT INTO EMPLOYEE VALUES (010, 'Alex Reyes', 'areyes@covid.sv', 'areyes741', 'casa numero 7,Lourdes,La Libertad',  3)
INSERT INTO EMPLOYEE VALUES (011, 'Maria Rivas', 'mrivas@covid.sv', 'mrivas357', 'casa numero 8,Izalco,Sonsonate',  3)
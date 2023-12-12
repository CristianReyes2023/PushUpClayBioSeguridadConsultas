CREATE DATABASE BioSeguridadDb;
USE BioSeguridadDb;

CREATE TABLE `COUNTRY` (
  `Id` INT UNIQUE PRIMARY KEY NOT NULL AUTO_INCREMENT,
  `NameCountry` VARCHAR(50) NOT NULL
);

CREATE TABLE `STATE` (
  `Id` INT UNIQUE PRIMARY KEY NOT NULL AUTO_INCREMENT,
  `NameState` VARCHAR(50) NOT NULL,
  `IdCountryFk` INT(11) NOT NULL
);

CREATE TABLE `CITY` (
  `Id` INT UNIQUE PRIMARY KEY NOT NULL AUTO_INCREMENT,
  `NameCity` VARCHAR(50) NOT NULL,
  `IdStateFk` INT(11) NOT NULL
);

CREATE TABLE `TYPEPERSON` (
  `Id` INT UNIQUE PRIMARY KEY NOT NULL AUTO_INCREMENT,
  `Description` TEXT(250) NOT NULL
);

CREATE TABLE `POSITION` (
  `Id` INT UNIQUE PRIMARY KEY NOT NULL AUTO_INCREMENT,
  `NamePosition` VARCHAR(50) NOT NULL
);

CREATE TABLE `TURNS` (
  `Id` INT UNIQUE PRIMARY KEY NOT NULL AUTO_INCREMENT,
  `NameTurns` VARCHAR(50) NOT NULL,
  `HourShiftStart` TIME NOT NULL,
  `HourShiftFinally` TIME NOT NULL
);

CREATE TABLE `CLIENT` (
  `Id` INT UNIQUE PRIMARY KEY NOT NULL AUTO_INCREMENT,
  `IdClient` VARCHAR(50) NOT NULL,
  `NameCliente` VARCHAR(50) NOT NULL,
  `DateRegister` DATETIME NOT NULL,
  `TelephoneNumber` VARCHAR(11) NOT NULL,
  `IdTPersonFk` INT(11),
  `IdCityFk` INT(11)
);

CREATE TABLE `EMPLOYEE` (
  `Id` INT UNIQUE PRIMARY KEY NOT NULL AUTO_INCREMENT,
  `IdEmployee` VARCHAR(50) NOT NULL,
  `NameEmployee` VARCHAR(50) NOT NULL,
  `DateRegister` DATETIME NOT NULL,
  `TelephoneNumber` VARCHAR(11) NOT NULL,
  `IdCityFk` INT(11) NOT NULL,
  `IdPositionFk` INT(11) NOT NULL
);

CREATE TABLE `ADDRESSOFFICE` (
  `Id` INT UNIQUE PRIMARY KEY NOT NULL AUTO_INCREMENT,
  `tipo_via` varchar(50),
  `numero_principal` smallint,
  `letra_principal` char(2),
  `bis` char(10),
  `letra_secundaria` char(2),
  `cardinal_primario` char(10),
  `numero_secundario` smallint,
  `cardinal_secundario` char(10),
  `complemento` varchar(50),
  `IdEmployeeFk` INT(11) NOT NULL
);

CREATE TABLE `ADDRESSCLIENT` (
  `Id` INT UNIQUE PRIMARY KEY NOT NULL AUTO_INCREMENT,
  `tipo_via` varchar(50),
  `numero_principal` smallint,
  `letra_principal` char(2),
  `bis` char(10),
  `letra_secundaria` char(2),
  `cardinal_primario` char(10),
  `numero_secundario` smallint,
  `cardinal_secundario` char(10),
  `complemento` varchar(50),
  `IdClientFk` INT(11) NOT NULL
);

CREATE TABLE `STATECONTRACT` (
  `Id` INT UNIQUE PRIMARY KEY NOT NULL AUTO_INCREMENT,
  `Description` TEXT(200) NOT NULL
);

CREATE TABLE `CONTRACT` (
  `Id` INT UNIQUE PRIMARY KEY NOT NULL AUTO_INCREMENT,
  `DateContract` DATETIME NOT NULL,
  `DATEFINAL` DATETIME NOT NULL,
  `IdClientFk` INT(11) NOT NULL,
  `IdEmployeeFk` INT(11) NOT NULL
);

CREATE TABLE `PROGRAMMING` (
  `Id` INT UNIQUE PRIMARY KEY NOT NULL AUTO_INCREMENT,
  `IdContractFk` INT(11) NOT NULL,
  `IdTurnFk` INT(11) NOT NULL,
  `IdEmployeeFk` INT(11) NOT NULL
);

ALTER TABLE `STATE` ADD FOREIGN KEY (`IdCountryFk`) REFERENCES `COUNTRY` (`Id`);

ALTER TABLE `CITY` ADD FOREIGN KEY (`IdStateFk`) REFERENCES `STATE` (`Id`);

ALTER TABLE `CLIENT` ADD FOREIGN KEY (`IdCityFk`) REFERENCES `CITY` (`Id`);

ALTER TABLE `EMPLOYEE` ADD FOREIGN KEY (`IdCityFk`) REFERENCES `CITY` (`Id`);

ALTER TABLE `CLIENT` ADD FOREIGN KEY (`IdTPersonFk`) REFERENCES `TYPEPERSON` (`Id`);

ALTER TABLE `EMPLOYEE` ADD FOREIGN KEY (`IdPositionFk`) REFERENCES `POSITION` (`Id`);

ALTER TABLE `ADDRESSCLIENT` ADD FOREIGN KEY (`IdClientFk`) REFERENCES `CLIENT` (`Id`);

ALTER TABLE `ADDRESSOFFICE` ADD FOREIGN KEY (`IdEmployeeFk`) REFERENCES `EMPLOYEE` (`Id`);

ALTER TABLE `CONTRACT` ADD FOREIGN KEY (`IdStateContractFk`) REFERENCES `STATECONTRACT` (`Id`);

ALTER TABLE `CONTRACT` ADD FOREIGN KEY (`IdEmployeeFk`) REFERENCES `EMPLOYEE` (`Id`);

ALTER TABLE `CONTRACT` ADD FOREIGN KEY (`IdClientFk`) REFERENCES `CLIENT` (`Id`);

ALTER TABLE `PROGRAMMING` ADD FOREIGN KEY (`IdContractFk`) REFERENCES `CONTRACT` (`Id`);

ALTER TABLE `PROGRAMMING` ADD FOREIGN KEY (`IdTurnFk`) REFERENCES `TURNS` (`Id`);

ALTER TABLE `PROGRAMMING` ADD FOREIGN KEY (`IdEmployeeFk`) REFERENCES `EMPLOYEE` (`Id`);


-- MySQL dump 10.13  Distrib 8.0.34, for Win64 (x86_64)
--
-- Host: localhost    Database: bioseguridaddb
-- ------------------------------------------------------
-- Server version	8.0.34

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Dumping data for table `__efmigrationshistory`
--

LOCK TABLES `__efmigrationshistory` WRITE;
/*!40000 ALTER TABLE `__efmigrationshistory` DISABLE KEYS */;
INSERT INTO `__efmigrationshistory` VALUES ('20231211174249_FirstMigrations','7.0.13'),('20231211182122_SecondMigrations','7.0.13'),('20231211184226_ThirdMigrations','7.0.13');
/*!40000 ALTER TABLE `__efmigrationshistory` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `addressclient`
--

LOCK TABLES `addressclient` WRITE;
/*!40000 ALTER TABLE `addressclient` DISABLE KEYS */;
INSERT INTO `addressclient` VALUES (1,'Calle',35,'A',NULL,NULL,NULL,NULL,NULL,'Barrio Porto',1),(2,'Carrera',3,'B',NULL,NULL,NULL,NULL,NULL,'Barrio Cabecera',2),(3,'Avenida',45,NULL,'B',NULL,NULL,NULL,NULL,'Barrio El Estadio',3);
/*!40000 ALTER TABLE `addressclient` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `addressoffice`
--

LOCK TABLES `addressoffice` WRITE;
/*!40000 ALTER TABLE `addressoffice` DISABLE KEYS */;
INSERT INTO `addressoffice` VALUES (1,'Calle',42,'A',NULL,NULL,NULL,NULL,NULL,'Barrio Candelaria',1),(2,'Avenida',14,'B',NULL,NULL,NULL,NULL,NULL,'Conjunto Nacional',2),(3,'Carrera ',50,'A',NULL,NULL,NULL,NULL,NULL,'Barrio Alpess',3);
/*!40000 ALTER TABLE `addressoffice` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `city`
--

LOCK TABLES `city` WRITE;
/*!40000 ALTER TABLE `city` DISABLE KEYS */;
INSERT INTO `city` VALUES (1,'Bucaramanga',1),(2,'Giron',1),(3,'Piedecuesta',1),(4,'Floridablanca',1);
/*!40000 ALTER TABLE `city` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `client`
--

LOCK TABLES `client` WRITE;
/*!40000 ALTER TABLE `client` DISABLE KEYS */;
INSERT INTO `client` VALUES (1,'12053','Cristian','2020-10-12 00:00:00','3116586',1,2),(2,'21465','VigilanciaAcro','2015-05-23 00:00:00','3562025',2,1),(3,'41351','Sergio','2018-06-22 00:00:00','2543556',1,3),(4,'45156','Camila','2019-06-11 00:00:00','1538436',1,4);
/*!40000 ALTER TABLE `client` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `contract`
--

LOCK TABLES `contract` WRITE;
/*!40000 ALTER TABLE `contract` DISABLE KEYS */;
/*!40000 ALTER TABLE `contract` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `country`
--

LOCK TABLES `country` WRITE;
/*!40000 ALTER TABLE `country` DISABLE KEYS */;
INSERT INTO `country` VALUES (1,'Peru'),(2,'Colombia');
/*!40000 ALTER TABLE `country` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `employee`
--

LOCK TABLES `employee` WRITE;
/*!40000 ALTER TABLE `employee` DISABLE KEYS */;
INSERT INTO `employee` VALUES (1,'10981','Jose','2010-10-20 00:00:00','321458645',2,1),(2,'10982','Pedro','2015-02-15 00:00:00','321785565',1,3),(3,'10983','Orlando','2016-11-15 00:00:00','352604662',3,3),(4,'10984','Maria','2020-08-12 00:00:00','325648875',4,4);
/*!40000 ALTER TABLE `employee` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `position`
--

LOCK TABLES `position` WRITE;
/*!40000 ALTER TABLE `position` DISABLE KEYS */;
INSERT INTO `position` VALUES (1,'Gerente'),(2,'Contandor'),(3,'Vigilante'),(4,'Secretaria');
/*!40000 ALTER TABLE `position` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `programming`
--

LOCK TABLES `programming` WRITE;
/*!40000 ALTER TABLE `programming` DISABLE KEYS */;
/*!40000 ALTER TABLE `programming` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `state`
--

LOCK TABLES `state` WRITE;
/*!40000 ALTER TABLE `state` DISABLE KEYS */;
INSERT INTO `state` VALUES (1,'Santander',2);
/*!40000 ALTER TABLE `state` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `statecontract`
--

LOCK TABLES `statecontract` WRITE;
/*!40000 ALTER TABLE `statecontract` DISABLE KEYS */;
INSERT INTO `statecontract` VALUES (1,'Prestación de servicios'),(2,'Ejecución papeleria'),(3,'Consultoria de seguridad'),(4,'Compra de equimamientos para vigilantes'),(5,'Vigilancia Cacique');
/*!40000 ALTER TABLE `statecontract` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `turns`
--

LOCK TABLES `turns` WRITE;
/*!40000 ALTER TABLE `turns` DISABLE KEYS */;
INSERT INTO `turns` VALUES (1,'Mañana','06:00:00','02:00:00'),(3,'Tarde','02:00:00','10:00:00'),(4,'Noche','10:00:00','06:00:00');
/*!40000 ALTER TABLE `turns` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `typeperson`
--

LOCK TABLES `typeperson` WRITE;
/*!40000 ALTER TABLE `typeperson` DISABLE KEYS */;
INSERT INTO `typeperson` VALUES (1,'Natural'),(2,'Juridical');
/*!40000 ALTER TABLE `typeperson` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-12-12  7:07:36


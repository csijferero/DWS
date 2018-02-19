CREATE DATABASE  IF NOT EXISTS `taxi` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `taxi`;
-- MySQL dump 10.13  Distrib 5.7.17, for Win64 (x86_64)
--
-- Host: localhost    Database: taxi
-- ------------------------------------------------------
-- Server version	5.7.19-log

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `carrera_suplemento`
--

DROP TABLE IF EXISTS `carrera_suplemento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `carrera_suplemento` (
  `idCarreraSuplemento` int(11) NOT NULL AUTO_INCREMENT,
  `idCarrera` int(11) NOT NULL,
  `idSuplemento` int(11) NOT NULL,
  PRIMARY KEY (`idCarreraSuplemento`),
  KEY `fk2_idx` (`idCarrera`),
  KEY `fk3_idx` (`idSuplemento`),
  CONSTRAINT `fk2` FOREIGN KEY (`idCarrera`) REFERENCES `carreras` (`idCarrera`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk3` FOREIGN KEY (`idSuplemento`) REFERENCES `suplementos` (`idSuplemento`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `carrera_suplemento`
--

LOCK TABLES `carrera_suplemento` WRITE;
/*!40000 ALTER TABLE `carrera_suplemento` DISABLE KEYS */;
/*!40000 ALTER TABLE `carrera_suplemento` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `carreras`
--

DROP TABLE IF EXISTS `carreras`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `carreras` (
  `idCarrera` int(11) NOT NULL AUTO_INCREMENT,
  `origen` varchar(45) NOT NULL,
  `destino` varchar(45) NOT NULL,
  `fecha` date NOT NULL,
  `metros` int(11) NOT NULL,
  `duracion` int(11) NOT NULL,
  `idTarifa` int(11) NOT NULL,
  `idConductor` int(11) NOT NULL,
  `idCliente` int(11) NOT NULL,
  PRIMARY KEY (`idCarrera`),
  KEY `fk1_idx` (`idTarifa`),
  KEY `fk4_idx` (`idConductor`),
  KEY `fk5_idx` (`idCliente`),
  CONSTRAINT `fk1` FOREIGN KEY (`idTarifa`) REFERENCES `tarifas` (`idTarifa`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk4` FOREIGN KEY (`idConductor`) REFERENCES `conductores` (`idConductor`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk5` FOREIGN KEY (`idCliente`) REFERENCES `clientes` (`idCliente`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=48 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `carreras`
--

LOCK TABLES `carreras` WRITE;
/*!40000 ALTER TABLE `carreras` DISABLE KEYS */;
INSERT INTO `carreras` VALUES (45,'Sevilla','Malaga','2018-01-01',250000,120,24,31,30),(47,'Malaga','Huelva','2020-07-09',254000,125,26,32,28);
/*!40000 ALTER TABLE `carreras` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `clientes`
--

DROP TABLE IF EXISTS `clientes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `clientes` (
  `idCliente` int(11) NOT NULL AUTO_INCREMENT,
  `nombreCliente` varchar(45) NOT NULL,
  `apellidosCliente` varchar(45) NOT NULL,
  `direccionCliente` varchar(45) NOT NULL,
  `emailCliente` varchar(45) NOT NULL,
  `dniCliente` varchar(45) NOT NULL,
  PRIMARY KEY (`idCliente`)
) ENGINE=InnoDB AUTO_INCREMENT=31 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `clientes`
--

LOCK TABLES `clientes` WRITE;
/*!40000 ALTER TABLE `clientes` DISABLE KEYS */;
INSERT INTO `clientes` VALUES (28,'Jose Antonio','Fernandez','Avd Los Rosales','jose@gmail.com','28598785-O'),(30,'Pepito','Popo','Avenida Resolana','popo@ono.es','25145875-R');
/*!40000 ALTER TABLE `clientes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `conductores`
--

DROP TABLE IF EXISTS `conductores`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `conductores` (
  `idConductor` int(11) NOT NULL AUTO_INCREMENT,
  `nombreConductor` varchar(45) NOT NULL,
  `apellidosConductor` varchar(45) NOT NULL,
  `direccionConductor` varchar(45) NOT NULL,
  `emailConductor` varchar(45) NOT NULL,
  `dniConductor` varchar(45) NOT NULL,
  `licenciaConductor` int(11) NOT NULL,
  `matriculaConductor` varchar(45) NOT NULL,
  PRIMARY KEY (`idConductor`)
) ENGINE=InnoDB AUTO_INCREMENT=33 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `conductores`
--

LOCK TABLES `conductores` WRITE;
/*!40000 ALTER TABLE `conductores` DISABLE KEYS */;
INSERT INTO `conductores` VALUES (31,'Manuel','Callado','Avd Pepapi','manu@ono.es','25147896-R',58,'5847PRT'),(32,'Rodolfo','Alfonso','Calle Peperoni','rodo@ono.es','25148597-L',958,'5847HTY');
/*!40000 ALTER TABLE `conductores` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `suplementos`
--

DROP TABLE IF EXISTS `suplementos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `suplementos` (
  `idSuplemento` int(11) NOT NULL AUTO_INCREMENT,
  `nombreSuplemento` varchar(45) NOT NULL,
  `precioSuplemento` double NOT NULL,
  PRIMARY KEY (`idSuplemento`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `suplementos`
--

LOCK TABLES `suplementos` WRITE;
/*!40000 ALTER TABLE `suplementos` DISABLE KEYS */;
INSERT INTO `suplementos` VALUES (13,'maleta',5);
/*!40000 ALTER TABLE `suplementos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tarifas`
--

DROP TABLE IF EXISTS `tarifas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tarifas` (
  `idTarifa` int(11) NOT NULL AUTO_INCREMENT,
  `numeroTarifa` double NOT NULL,
  `precioBandera` double NOT NULL,
  `precioDuracion` double NOT NULL,
  `precioMetros` double NOT NULL,
  PRIMARY KEY (`idTarifa`)
) ENGINE=InnoDB AUTO_INCREMENT=27 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tarifas`
--

LOCK TABLES `tarifas` WRITE;
/*!40000 ALTER TABLE `tarifas` DISABLE KEYS */;
INSERT INTO `tarifas` VALUES (24,1.1,1.5,0.2,0.8),(26,1.2,0.9,0.95,0.5);
/*!40000 ALTER TABLE `tarifas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuarios`
--

DROP TABLE IF EXISTS `usuarios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `usuarios` (
  `idUsuario` int(11) NOT NULL AUTO_INCREMENT,
  `nombreUsuario` varchar(50) NOT NULL,
  `aliasUsuario` varchar(4) NOT NULL,
  `loginUsuario` varchar(10) NOT NULL,
  `claveUsuario` varchar(45) NOT NULL,
  `accesoUsuario` int(1) NOT NULL,
  PRIMARY KEY (`idUsuario`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuarios`
--

LOCK TABLES `usuarios` WRITE;
/*!40000 ALTER TABLE `usuarios` DISABLE KEYS */;
INSERT INTO `usuarios` VALUES (7,'root','ADMI','root','YQBsAHQAYQBpAHIA',1),(9,'user','USER','user','MQAyADMANAA=',2),(10,'Usuario Desactivado','DESA','des','MQAyADMANAA=',0);
/*!40000 ALTER TABLE `usuarios` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2017-12-22  4:12:30

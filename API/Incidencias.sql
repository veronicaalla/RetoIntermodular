-- MySQL dump 10.13  Distrib 8.0.29, for Win64 (x86_64)
--
-- Host: localhost    Database: incidencias
-- ------------------------------------------------------
-- Server version	8.0.29

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
-- Table structure for table `aulas`
--

DROP TABLE IF EXISTS `aulas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `aulas` (
  `num` int NOT NULL,
  `codigo` varchar(8) CHARACTER SET utf8mb3 COLLATE utf8_spanish_ci NOT NULL,
  `descripcion` varchar(100) CHARACTER SET utf8mb3 COLLATE utf8_spanish_ci NOT NULL,
  `planta` int NOT NULL,
  PRIMARY KEY (`num`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3 COLLATE=utf8_spanish_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `aulas`
--

LOCK TABLES `aulas` WRITE;
/*!40000 ALTER TABLE `aulas` DISABLE KEYS */;
INSERT INTO `aulas` VALUES (1,'01','Aula TIC',2),(2,'A102','Aula de matemáticas',1),(3,'B201','Laboratorio de física',2),(4,'B202','Sala de conferencias',2);
/*!40000 ALTER TABLE `aulas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `comentarios`
--

DROP TABLE IF EXISTS `comentarios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `comentarios` (
  `id` int NOT NULL AUTO_INCREMENT,
  `texto` text CHARACTER SET utf8mb3 COLLATE utf8_spanish_ci NOT NULL,
  `fechahora` datetime NOT NULL,
  `incidencia_num` int NOT NULL,
  `personal_id` int NOT NULL,
  `adjunto_url` text CHARACTER SET utf8mb3 COLLATE utf8_spanish_ci,
  PRIMARY KEY (`id`),
  KEY `fk_comentarios_incidencias1_idx` (`incidencia_num`),
  KEY `fk_comentarios_personal1_idx` (`personal_id`),
  CONSTRAINT `fk_comentarios_incidencias1` FOREIGN KEY (`incidencia_num`) REFERENCES `incidencias` (`num`),
  CONSTRAINT `fk_comentarios_personal1` FOREIGN KEY (`personal_id`) REFERENCES `personal` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8mb3 COLLATE=utf8_spanish_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `comentarios`
--

LOCK TABLES `comentarios` WRITE;
/*!40000 ALTER TABLE `comentarios` DISABLE KEYS */;
INSERT INTO `comentarios` VALUES (9,'Este es el primer comentario','2024-02-09 10:00:00',1,1,'adjunto1.jpg'),(10,'Segundo comentario sobre la incidencia','2024-02-10 11:00:00',7,2,NULL),(11,'Tercer comentario importante','2024-02-11 12:00:00',8,3,'adjunto2.jpg'),(12,'Último comentario para esta incidencia','2024-02-12 13:00:00',9,4,NULL);
/*!40000 ALTER TABLE `comentarios` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `departamentos`
--

DROP TABLE IF EXISTS `departamentos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `departamentos` (
  `id` int NOT NULL AUTO_INCREMENT,
  `cod` char(6) CHARACTER SET utf8mb3 COLLATE utf8_spanish_ci NOT NULL,
  `nombre` varchar(45) CHARACTER SET utf8mb3 COLLATE utf8_spanish_ci NOT NULL,
  `activo` tinyint NOT NULL DEFAULT '1',
  `jefedep_id` int DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_departamentos_personal1_idx` (`jefedep_id`),
  CONSTRAINT `fk_departamentos_personal1` FOREIGN KEY (`jefedep_id`) REFERENCES `personal` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb3 COLLATE=utf8_spanish_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `departamentos`
--

LOCK TABLES `departamentos` WRITE;
/*!40000 ALTER TABLE `departamentos` DISABLE KEYS */;
INSERT INTO `departamentos` VALUES (1,'23','Mates',1,1),(2,'102','Fisica',1,3);
/*!40000 ALTER TABLE `departamentos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `equipos`
--

DROP TABLE IF EXISTS `equipos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `equipos` (
  `id` int NOT NULL,
  `tipo_equipo` enum('altavoces','impresora','monitor','pantalla_interactiva','portátil_de_aula','portátil_Consejería','proyector') COLLATE utf8_spanish_ci NOT NULL,
  `fecha_adquisicion` date DEFAULT NULL,
  `etiqueta` char(8) CHARACTER SET utf8mb3 COLLATE utf8_spanish_ci NOT NULL,
  `marca` varchar(20) CHARACTER SET utf8mb3 COLLATE utf8_spanish_ci NOT NULL,
  `modelo` varchar(45) CHARACTER SET utf8mb3 COLLATE utf8_spanish_ci DEFAULT NULL,
  `descripcion` text CHARACTER SET utf8mb3 COLLATE utf8_spanish_ci,
  `baja` tinyint DEFAULT '0',
  `aula_num` int NOT NULL,
  `puesto` int DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_equipos_aulas1_idx` (`aula_num`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3 COLLATE=utf8_spanish_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `equipos`
--

LOCK TABLES `equipos` WRITE;
/*!40000 ALTER TABLE `equipos` DISABLE KEYS */;
INSERT INTO `equipos` VALUES (1,'proyector','2020-10-11','AGH','Asus','WIng','alalalalalalla',0,1,12),(2,'portátil_de_aula','2018-05-06','AMS','Asus','LL','akakskk',0,1,3),(3,'monitor','2023-03-10','EQ003','AOC','27B2H','Monitor LED de 27 pulgadas',0,1,4),(4,'pantalla_interactiva','2023-04-05','EQ004','Promethean','ActivPanel','Pantalla táctil interactiva',0,4,3),(5,'portátil_de_aula','2023-05-20','EQ005','Lenovo','ThinkPad L14','Portátil para uso en aulas',0,1,1),(6,'portátil_Consejería','2023-06-12','EQ006','Dell','Latitude 5420','Portátil para uso en la consejería',0,1,2),(7,'proyector','2023-07-30','EQ007','Epson','EB-X05','Proyector de vídeo de alta definición',0,1,5),(8,'altavoces','2023-08-18','EQ008','JBL','Charge 4','Altavoz portátil resistente al agua',0,1,6),(9,'impresora','2023-09-25','EQ009','Canon','PIXMA TS6350','Impresora multifunción de inyección de tinta',0,1,7),(10,'monitor','2023-10-03','EQ010','Samsung','S27R350','Monitor LED de 27 pulgadas',0,1,8);
/*!40000 ALTER TABLE `equipos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `incidencias`
--

DROP TABLE IF EXISTS `incidencias`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `incidencias` (
  `num` int NOT NULL AUTO_INCREMENT,
  `tipo` enum('EQUIPOS','CUENTAS','WIFI','INTERNET','SOFTWARE') CHARACTER SET utf8mb3 COLLATE utf8_spanish_ci NOT NULL,
  `subtipo_id` int NOT NULL,
  `fecha_creacion` datetime NOT NULL,
  `fecha_cierre` datetime DEFAULT NULL,
  `descripcion` text CHARACTER SET utf8mb3 COLLATE utf8_spanish_ci NOT NULL,
  `estado` enum('abierta','asignada','en_proceso','enviada_a_Infortec','resuelta','cerrada') COLLATE utf8_spanish_ci NOT NULL,
  `adjunto_url` text CHARACTER SET utf8mb3 COLLATE utf8_spanish_ci,
  `creador_id` int NOT NULL,
  `responsable_id` int DEFAULT NULL,
  `equipo_id` int DEFAULT NULL,
  `tiempo_dec` time DEFAULT NULL,
  PRIMARY KEY (`num`),
  KEY `fk_incidencias_incidencias_subtipos1_idx` (`subtipo_id`),
  KEY `fk_incidencias_personal1_idx` (`creador_id`),
  KEY `fk_incidencias_personal2_idx` (`responsable_id`),
  KEY `fk_incidencias_equipos1_idx` (`equipo_id`),
  CONSTRAINT `fk_incidencias_equipos1` FOREIGN KEY (`equipo_id`) REFERENCES `equipos` (`id`),
  CONSTRAINT `fk_incidencias_incidencias_subtipos1` FOREIGN KEY (`subtipo_id`) REFERENCES `incidencias_subtipos` (`id`),
  CONSTRAINT `fk_incidencias_personal1` FOREIGN KEY (`creador_id`) REFERENCES `personal` (`id`),
  CONSTRAINT `fk_incidencias_personal2` FOREIGN KEY (`responsable_id`) REFERENCES `personal` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8mb3 COLLATE=utf8_spanish_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `incidencias`
--

LOCK TABLES `incidencias` WRITE;
/*!40000 ALTER TABLE `incidencias` DISABLE KEYS */;
INSERT INTO `incidencias` VALUES (1,'EQUIPOS',1,'2024-01-01 00:00:00',NULL,'aaaaaaa','abierta','aaaaaa',1,1,NULL,NULL),(7,'EQUIPOS',1,'2024-02-09 10:00:00','2024-02-09 12:00:00','Descripción de la incidencia 1','abierta','adjunto1.jpg',1,2,1,NULL),(8,'CUENTAS',2,'2024-02-10 10:00:00','2024-02-10 12:00:00','Descripción de la incidencia 2','abierta','adjunto2.jpg',2,3,2,NULL),(9,'WIFI',3,'2024-02-11 10:00:00','2024-02-11 12:00:00','Descripción de la incidencia 3','abierta',NULL,3,4,3,NULL),(10,'INTERNET',1,'2024-02-12 10:00:00','2024-02-12 12:00:00','Descripción de la incidencia 4','cerrada','adjunto3.jpg',1,2,1,NULL),(11,'SOFTWARE',2,'2024-02-13 10:00:00','2024-02-13 12:00:00','Descripción de la incidencia 5','cerrada',NULL,2,3,2,NULL),(12,'EQUIPOS',3,'2024-02-14 10:00:00','2024-02-14 12:00:00','Descripción de la incidencia 6','abierta','adjunto4.jpg',3,4,3,NULL);
/*!40000 ALTER TABLE `incidencias` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `incidencias_subtipos`
--

DROP TABLE IF EXISTS `incidencias_subtipos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `incidencias_subtipos` (
  `id` int NOT NULL AUTO_INCREMENT,
  `tipo` enum('EQUIPOS','CUENTAS','WIFI','INTERNET','SOFTWARE') CHARACTER SET utf8mb3 COLLATE utf8_spanish_ci NOT NULL,
  `subtipo_nombre` varchar(20) CHARACTER SET utf8mb3 COLLATE utf8_spanish_ci NOT NULL,
  `sub_subtipo` varchar(40) CHARACTER SET utf8mb3 COLLATE utf8_spanish_ci DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=19 DEFAULT CHARSET=utf8mb3 COLLATE=utf8_spanish_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `incidencias_subtipos`
--

LOCK TABLES `incidencias_subtipos` WRITE;
/*!40000 ALTER TABLE `incidencias_subtipos` DISABLE KEYS */;
INSERT INTO `incidencias_subtipos` VALUES (1,'EQUIPOS','PC','ORDENADOR'),(2,'EQUIPOS','PC','RATÓN'),(3,'EQUIPOS','PC','TECLADO'),(4,'EQUIPOS','ALTAVOCES',NULL),(5,'EQUIPOS','MONITOR',NULL),(6,'EQUIPOS','PROYECTOR',NULL),(7,'EQUIPOS','PANTALLA',NULL),(8,'EQUIPOS','PORTÁTIL','PROPORCIONADO POR CONSEJERÍA'),(9,'EQUIPOS','PORTÁTIL','DE AULA'),(10,'EQUIPOS','IMPRESORA',NULL),(11,'CUENTAS','EDUCANTABRIA',NULL),(12,'CUENTAS','GOOGLE CLASSROOM',NULL),(13,'CUENTAS','DOMINIO',NULL),(14,'CUENTAS','YEDRA','GESTIONA J.EST.'),(15,'WIFI','iesmiguelherrero',NULL),(16,'WIFI','WIECAN',NULL),(17,'INTERNET','INSTALACIÓN',NULL),(18,'INTERNET','ACTUALIZACIÓN',NULL);
/*!40000 ALTER TABLE `incidencias_subtipos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `perfiles`
--

DROP TABLE IF EXISTS `perfiles`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `perfiles` (
  `personal_id` int NOT NULL,
  `dominio` varchar(15) CHARACTER SET utf8mb3 COLLATE utf8_spanish_ci DEFAULT NULL,
  `educantabria` varchar(50) CHARACTER SET utf8mb3 COLLATE utf8_spanish_ci DEFAULT NULL,
  `password` char(32) CHARACTER SET utf8mb3 COLLATE utf8_spanish_ci DEFAULT NULL,
  `perfil` enum('administrador','profesor','otros') COLLATE utf8_spanish_ci NOT NULL DEFAULT 'profesor',
  PRIMARY KEY (`personal_id`),
  CONSTRAINT `fk_perfiles_personal` FOREIGN KEY (`personal_id`) REFERENCES `personal` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3 COLLATE=utf8_spanish_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `perfiles`
--

LOCK TABLES `perfiles` WRITE;
/*!40000 ALTER TABLE `perfiles` DISABLE KEYS */;
INSERT INTO `perfiles` VALUES (1,'example.com','usuario1@educantabria.es','hashed_password_1','administrador'),(2,'example.com','usuario2@educantabria.es','hashed_password_2','profesor'),(3,'example.com','usuario3@educantabria.es','hashed_password_3','otros'),(4,'example.com','usuario4@educantabria.es','hashed_password_4','profesor');
/*!40000 ALTER TABLE `perfiles` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `personal`
--

DROP TABLE IF EXISTS `personal`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `personal` (
  `id` int NOT NULL AUTO_INCREMENT,
  `dni` char(9) CHARACTER SET utf8mb3 COLLATE utf8_spanish_ci DEFAULT NULL,
  `nombre` varchar(25) CHARACTER SET utf8mb3 COLLATE utf8_spanish_ci NOT NULL,
  `apellido1` varchar(25) CHARACTER SET utf8mb3 COLLATE utf8_spanish_ci NOT NULL,
  `apellido2` varchar(25) CHARACTER SET utf8mb3 COLLATE utf8_spanish_ci DEFAULT NULL,
  `direccion` varchar(80) CHARACTER SET utf8mb3 COLLATE utf8_spanish_ci DEFAULT NULL,
  `localidad` varchar(25) CHARACTER SET utf8mb3 COLLATE utf8_spanish_ci DEFAULT NULL,
  `cp` char(5) CHARACTER SET utf8mb3 COLLATE utf8_spanish_ci DEFAULT NULL,
  `tlf` char(9) CHARACTER SET utf8mb3 COLLATE utf8_spanish_ci DEFAULT NULL,
  `activo` tinyint DEFAULT '1',
  `departamento_id` int DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `dni_UNIQUE` (`dni`),
  KEY `fk_personal_departamentos1_idx` (`departamento_id`),
  CONSTRAINT `fk_personal_departamentos1` FOREIGN KEY (`departamento_id`) REFERENCES `departamentos` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb3 COLLATE=utf8_spanish_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `personal`
--

LOCK TABLES `personal` WRITE;
/*!40000 ALTER TABLE `personal` DISABLE KEYS */;
INSERT INTO `personal` VALUES (1,'1','Juan','Juan','Juan','Lalalala','lilili','1234','1234',1,1),(2,'87654321B','María','Gómez',NULL,'Calle San Pablo 2','Madrid','28002','987654321',1,1),(3,'56789123C','Pedro','Martínez',NULL,'Calle Gran Vía 3','Madrid','28003','456789123',1,1),(4,'43218765D','Laura','López',NULL,'Calle Alcalá 4','Madrid','28004','654321987',1,1),(5,'12345678','Juan','Dominguez','Millan','Avenida san fernado','Meruelo','3000','123456789',1,1);
/*!40000 ALTER TABLE `personal` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-02-09 19:34:35

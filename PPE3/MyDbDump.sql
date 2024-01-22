-- MySQL dump 10.13  Distrib 8.2.0, for Win64 (x86_64)
--
-- Host: localhost    Database: ppe3
-- ------------------------------------------------------
-- Server version	8.2.0

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `allergie`
--

DROP TABLE IF EXISTS `allergie`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `allergie` (
  `id_all` int NOT NULL AUTO_INCREMENT,
  `nom_all` varchar(60) NOT NULL,
  PRIMARY KEY (`id_all`)
) ENGINE=MyISAM AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `allergie`
--

LOCK TABLES `allergie` WRITE;
/*!40000 ALTER TABLE `allergie` DISABLE KEYS */;
INSERT INTO `allergie` VALUES (1,'Allergie ├á l\'aspirine'),(2,'Allergie au parac├®tamol'),(3,'R├®action allergique aux p├®nicillines'),(4,'Allergie au antibiotiques');
/*!40000 ALTER TABLE `allergie` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `antecedent`
--

DROP TABLE IF EXISTS `antecedent`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `antecedent` (
  `id_antec` int NOT NULL AUTO_INCREMENT,
  `nom_antec` varchar(2048) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  PRIMARY KEY (`id_antec`)
) ENGINE=MyISAM AUTO_INCREMENT=17 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `antecedent`
--

LOCK TABLES `antecedent` WRITE;
/*!40000 ALTER TABLE `antecedent` DISABLE KEYS */;
INSERT INTO `antecedent` VALUES (1,'Ulc├¿res gastriques actifs'),(2,'Tendinite'),(3,'Insuffisance r├®nale'),(4,'Grossesse'),(5,'Hyperkali├®mie'),(6,'Hypotension s├®v├¿re'),(7,'Syndrome s├®rotoninergique'),(8,'Maladie du foie active'),(9,'D├®pendance aux substances'),(10,'Infections fongiques syst├®miques'),(11,'Angioed├¿me'),(12,'Tachycardie'),(13,'D├®pendance'),(14,'Porphyrie aigu├½'),(15,'Saignement actif');
/*!40000 ALTER TABLE `antecedent` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `avoir`
--

DROP TABLE IF EXISTS `avoir`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `avoir` (
  `id_antec` int NOT NULL,
  `id_pat` int NOT NULL,
  PRIMARY KEY (`id_antec`,`id_pat`),
  KEY `avoir_patient0_FK` (`id_pat`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `avoir`
--

LOCK TABLES `avoir` WRITE;
/*!40000 ALTER TABLE `avoir` DISABLE KEYS */;
INSERT INTO `avoir` VALUES (0,0),(0,1),(1,6),(2,25),(3,14),(4,5),(13,7),(15,17),(23,23);
/*!40000 ALTER TABLE `avoir` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `etre`
--

DROP TABLE IF EXISTS `etre`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `etre` (
  `id_all` int NOT NULL,
  `id_pat` int NOT NULL,
  PRIMARY KEY (`id_all`,`id_pat`),
  KEY `etre_patient0_FK` (`id_pat`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `etre`
--

LOCK TABLES `etre` WRITE;
/*!40000 ALTER TABLE `etre` DISABLE KEYS */;
INSERT INTO `etre` VALUES (0,0),(0,1),(1,2),(1,26),(3,25),(4,1),(5,3),(23,23);
/*!40000 ALTER TABLE `etre` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `incompatible`
--

DROP TABLE IF EXISTS `incompatible`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `incompatible` (
  `id` int NOT NULL AUTO_INCREMENT,
  `id_antec` int DEFAULT NULL,
  `id_medoc` int NOT NULL,
  `id_all` int DEFAULT NULL,
  `id_medoc_medicament` int DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `incompatible_antecedent_FK` (`id_antec`),
  KEY `incompatible_medicament0_FK` (`id_medoc`),
  KEY `incompatible_allergie1_FK` (`id_all`),
  KEY `incompatible_medicament2_FK` (`id_medoc_medicament`)
) ENGINE=MyISAM AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `incompatible`
--

LOCK TABLES `incompatible` WRITE;
/*!40000 ALTER TABLE `incompatible` DISABLE KEYS */;
INSERT INTO `incompatible` VALUES (1,NULL,3,2,NULL),(2,-1,1,1,NULL);
/*!40000 ALTER TABLE `incompatible` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `medecin`
--

DROP TABLE IF EXISTS `medecin`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `medecin` (
  `id_medc` int NOT NULL AUTO_INCREMENT,
  `nom_medc` varchar(30) NOT NULL,
  `prenom_medc` varchar(30) NOT NULL,
  `nom_user_medc` varchar(60) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `password_medc` varchar(60) NOT NULL,
  PRIMARY KEY (`id_medc`)
) ENGINE=MyISAM AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `medecin`
--

LOCK TABLES `medecin` WRITE;
/*!40000 ALTER TABLE `medecin` DISABLE KEYS */;
INSERT INTO `medecin` VALUES (1,'Duvar','S├®bastien','duvar.sebastien','Soleil-Duc34'),(2,'Rocher','Isabelle','rocher.isabelle','Lune-Duc34'),(3,'Admin','Ayoub','ad','root');
/*!40000 ALTER TABLE `medecin` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `medicament`
--

DROP TABLE IF EXISTS `medicament`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `medicament` (
  `id_medoc` int NOT NULL AUTO_INCREMENT,
  `nom_medoc` varchar(60) NOT NULL,
  PRIMARY KEY (`id_medoc`)
) ENGINE=MyISAM AUTO_INCREMENT=29 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `medicament`
--

LOCK TABLES `medicament` WRITE;
/*!40000 ALTER TABLE `medicament` DISABLE KEYS */;
INSERT INTO `medicament` VALUES (1,'Aspirine'),(2,'Parac├®tamol'),(3,'Ibuprof├¿ne'),(4,'Amoxicilline'),(5,'Ciprofloxacine'),(6,'Metformine'),(7,'Omeprazole'),(8,'Losartan'),(9,'Simvastatine'),(10,'Amlodipine'),(11,'Atorvastatine'),(12,'Sertraline'),(13,'Fluoxetine'),(14,'Diazepam'),(15,'Prednisone'),(16,'Lisinopril'),(17,'Albuterol'),(18,'Gabapentine'),(19,'Ranitidine'),(20,'Warfarine');
/*!40000 ALTER TABLE `medicament` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ordonnance`
--

DROP TABLE IF EXISTS `ordonnance`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `ordonnance` (
  `id_ordo` int NOT NULL AUTO_INCREMENT,
  `posologie_ordo` varchar(5000) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `duree_traitement_ordo` int NOT NULL,
  `instruction_ordo` varchar(5000) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `id_medc` int DEFAULT NULL,
  `id_pat` int DEFAULT NULL,
  `id_medoc` int DEFAULT NULL,
  PRIMARY KEY (`id_ordo`),
  KEY `FK_id_medc_ordo` (`id_medc`),
  KEY `FK_id_pat_ordo` (`id_pat`),
  KEY `FK_id_medoc_ordo` (`id_medoc`)
) ENGINE=MyISAM AUTO_INCREMENT=15 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ordonnance`
--

LOCK TABLES `ordonnance` WRITE;
/*!40000 ALTER TABLE `ordonnance` DISABLE KEYS */;
INSERT INTO `ordonnance` VALUES (1,'prendre 3j',2,'interdit au enfant ',0,0,0),(2,'A boire avec de l\'eau',5,'Atterdit au enfant',0,0,0),(3,'├Ç prendre 2 fois par jour (matin et soir)',0,'',1,2,11),(4,'La dose recommand├®e est de 20 mg d\'om├®prazole par jour',4,'Prendre avant le repas du matin en cas de sympt├┤mes pr├®dominants durant la journ├®e, et avant le repas du soir en cas de sympt├┤mes pr├®dominants durant la nuit.',2,3,7),(5,'250 mg ├á 500 mg trois fois par jour ou 750 mg ├á 1 g toutes les 12h, selon la s├®v├®rit├® et le type d\'infection. ┬À Infections s├®v├¿res : 750 mg ├á 1 g trois fois par jour.',2,'Infections s├®v├¿res : 750 mg ├á 1 g trois fois par jour. \nInfection des voies urinaires : 3 g deux fois par jour pendant un jour.',2,5,4);
/*!40000 ALTER TABLE `ordonnance` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `patient`
--

DROP TABLE IF EXISTS `patient`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `patient` (
  `id_pat` int NOT NULL AUTO_INCREMENT,
  `nom_pat` varchar(30) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `prenom_pat` varchar(30) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `age_pat` int NOT NULL,
  `sexe_pat` char(5) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  PRIMARY KEY (`id_pat`)
) ENGINE=MyISAM AUTO_INCREMENT=27 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `patient`
--

LOCK TABLES `patient` WRITE;
/*!40000 ALTER TABLE `patient` DISABLE KEYS */;
INSERT INTO `patient` VALUES (1,'Boulaoui','Karim',34,'M'),(2,'Bourger','Virgine',26,'F'),(3,'Lee','Thai',20,'M'),(4,'Montrocher','Claude',46,'F'),(5,'Zmyach','Aziz',46,'M'),(6,'Kalini','Mathieu',32,'M'),(7,'G├®rard','Dim├®trie',47,'M'),(17,'Zoubir','Lucas',19,'M'),(21,'Claude','France',37,'F'),(22,'Boulard','Marie',24,'F'),(23,'Manol','Many',23,'M'),(24,'Mikolo','Pierre',29,'M'),(25,'Mikolos','Pierre',29,'M'),(26,'Rouillard','Michel',64,'M');
/*!40000 ALTER TABLE `patient` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-01-22  1:06:27

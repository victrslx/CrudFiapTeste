DROP database IF EXISTS `__efmigrationshistory`;
create database dbprovacrudfiap;
use dbprovacrudfiap;



DROP TABLE IF EXISTS `__efmigrationshistory`;

CREATE TABLE `__efmigrationshistory` (
  `MigrationId` varchar(150) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `ProductVersion` varchar(32) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  PRIMARY KEY (`MigrationId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;


LOCK TABLES `__efmigrationshistory` WRITE;

INSERT INTO `__efmigrationshistory` VALUES ('20230123020325_initial','5.0.17');

UNLOCK TABLES;

DROP TABLE IF EXISTS `userpromotionregister`;

CREATE TABLE `userpromotionregister` (
  `id` int NOT NULL AUTO_INCREMENT,
  `name` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `email` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `number` int NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;




LOCK TABLES `userpromotionregister` WRITE;

INSERT INTO `userpromotionregister` VALUES (2,'João Victor Ferreira Faustino Fortes','jfaustinooit@gmail.com',987424265);

UNLOCK TABLES;

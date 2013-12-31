CREATE DATABASE IF NOT EXISTS `projecttemplate`;
USE `projecttemplate`;
CREATE USER 'personaluser' IDENTIFIED BY 'personalpass';
GRANT ALL PRIVILEGES ON * . * TO 'personaluser';

CREATE TABLE `Product` (
	`ProductId` VARCHAR(36) NOT NULL,
	`ProductName` VARCHAR(50) NOT NULL,
	`ProductDescription` VARCHAR(500) NOT NULL,
	PRIMARY KEY (`productid`)
);

INSERT INTO `projecttemplate`.`Product` (`ProductId`, `ProductName`, `ProductDescription`) VALUES ('89C1648D-09F6-4E11-B58F-30D0F6475604', 'This is the Name', 'This is the description');

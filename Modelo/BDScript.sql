-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------
-- -----------------------------------------------------
-- Schema ticket
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema ticket
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `ticket` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci ;
USE `ticket` ;

-- -----------------------------------------------------
-- Table `ticket`.`municipio`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `ticket`.`municipio` (
  `CODMUNICIPIO` INT NOT NULL,
  `NOMBREMUNICIPIO` VARCHAR(50) NULL DEFAULT NULL,
  PRIMARY KEY (`CODMUNICIPIO`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `ticket`.`administrador`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `ticket`.`administrador` (
  `CODADMINISTRADOR` VARCHAR(18) NOT NULL,
  `CODMUNICIPIO` INT NULL DEFAULT NULL,
  `NOMBREADMIN` VARCHAR(30) NULL DEFAULT NULL,
  `PATERNOADMIN` VARCHAR(30) NULL DEFAULT NULL,
  `MATERNOADMIN` VARCHAR(30) NULL DEFAULT NULL,
  `CONTRASEÑA` VARCHAR(15) NOT NULL,
  PRIMARY KEY (`CODADMINISTRADOR`),
  INDEX `FK_CORRESPONDE2` (`CODMUNICIPIO` ASC) VISIBLE,
  CONSTRAINT `FK_CORRESPONDE2`
    FOREIGN KEY (`CODMUNICIPIO`)
    REFERENCES `ticket`.`municipio` (`CODMUNICIPIO`)
    ON DELETE RESTRICT
    ON UPDATE RESTRICT)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `ticket`.`alumnos`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `ticket`.`alumnos` (
  `CURP` VARCHAR(18) NOT NULL,
  `CODMUNICIPIO` INT NULL DEFAULT NULL,
  `NOMBRE_S_ALUM` VARCHAR(30) NULL DEFAULT NULL,
  `PATERNOALUM` VARCHAR(30) NULL DEFAULT NULL,
  `MATERNOALUM` VARCHAR(30) NULL DEFAULT NULL,
  `NIVELCURSA` VARCHAR(30) NULL DEFAULT NULL,
  PRIMARY KEY (`CURP`),
  INDEX `FK_CORRESPONDE` (`CODMUNICIPIO` ASC) VISIBLE,
  CONSTRAINT `FK_CORRESPONDE`
    FOREIGN KEY (`CODMUNICIPIO`)
    REFERENCES `ticket`.`municipio` (`CODMUNICIPIO`)
    ON DELETE RESTRICT
    ON UPDATE RESTRICT)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `ticket`.`citas`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `ticket`.`citas` (
  `IDCITA` INT NOT NULL AUTO_INCREMENT,
  `QUIENR` VARCHAR(9) NULL DEFAULT NULL,
  `TELEFONOQR` VARCHAR(10) NULL DEFAULT NULL,
  `CORREOQR` VARCHAR(70) NULL DEFAULT NULL,
  `STATUS` VARCHAR(10) NULL DEFAULT NULL,
  PRIMARY KEY (`IDCITA`))
ENGINE = InnoDB
AUTO_INCREMENT = 8
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `ticket`.`realiza`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `ticket`.`realiza` (
  `IDCITA` INT NOT NULL,
  `CURP` VARCHAR(18) NOT NULL,
  `NUMTURNO` INT NULL DEFAULT NULL,
  `ASUNTOTRATAR` VARCHAR(100) NULL DEFAULT NULL,
  PRIMARY KEY (`IDCITA`, `CURP`),
  INDEX `FK_REALIZA2` (`CURP` ASC) VISIBLE,
  CONSTRAINT `FK_REALIZA`
    FOREIGN KEY (`IDCITA`)
    REFERENCES `ticket`.`citas` (`IDCITA`)
    ON DELETE RESTRICT
    ON UPDATE RESTRICT,
  CONSTRAINT `FK_REALIZA2`
    FOREIGN KEY (`CURP`)
    REFERENCES `ticket`.`alumnos` (`CURP`)
    ON DELETE RESTRICT
    ON UPDATE RESTRICT)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;

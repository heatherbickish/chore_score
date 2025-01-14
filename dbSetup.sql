-- Active: 1736871714737@@127.0.0.1@3306@insightful_ocean_7962_db
CREATE TABLE IF NOT EXISTS accounts(
  id VARCHAR(255) NOT NULL primary key COMMENT 'primary key',
  createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',
  updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update',
  name varchar(255) COMMENT 'User Name',
  email varchar(255) UNIQUE COMMENT 'User Email',
  picture varchar(255) COMMENT 'User Picture'
) default charset utf8mb4 COMMENT '';


CREATE TABLE chores(
  id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
  name VARCHAR(255) NOT NULL,
  description VARCHAR(255) NOT NULL,
  isComplete BOOLEAN DEFAULT false NOT NULL
);

DROP TABLE chores;

INSERT INTO 
chores(name, description, isComplete)
VALUES("Walk the kitties", "Don't go to PetCo, we are banned for life.", 1),
("Get out of the house", "Go for a walk, run to the store, anything! I'm turning hermity", 0),
("Drop off donations", "They've been in the back of the car for the last 7 months.", 1),
("Clean the kitchen", "I have no more clean silverware and 1 bowl", 1),
("Write letter", "They won't know unless you write it...", 0);

SELECT * FROM chores;

SELECT * FROM chores WHERE id = 2;

DELETE FROM chores WHERE id = 1;

DELETE FROM chores;
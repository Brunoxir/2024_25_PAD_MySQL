CREATE TABLE `szkola`.`uczen` ( `id` INT NOT NULL AUTO_INCREMENT , `imie` TEXT NOT NULL , `nazwisko` TEXT NOT NULL , `klasa` TEXT NOT NULL , PRIMARY KEY (`id`)) ENGINE = InnoDB;
SELECT * FROM `uczen`
RENAME TABLE `szkola`.`uczen` TO `szkola`.`uczniowie`;
SELECT * FROM `uczniowie`
INSERT INTO `uczniowie` (`id`, `imie`, `nazwisko`, `klasa`) VALUES (NULL, 'Oskar', 'Kowalski', '4P'), (NULL, 'Adam', 'Kasprzak', '4p');
SELECT * FROM `uczniowie`
Zwiń Wykonaj zapytanie ponownie Edytuj Dodaj do zakładek Baza danych : Czas zapytania : 12:37:20
CREATE USER 'uczen'@'%' IDENTIFIED VIA mysql_native_password USING '***';GRANT USAGE ON *.* TO 'uczen'@'%' REQUIRE NONE WITH MAX_QUERIES_PER_HOUR 0 MAX_CONNECTIONS_PER_HOUR 0 MAX_UPDATES_PER_HOUR 0 MAX_USER_CONNECTIONS 0;GRANT ALL PRIVILEGES ON `szkola`.* TO 'uczen'@'%';
​

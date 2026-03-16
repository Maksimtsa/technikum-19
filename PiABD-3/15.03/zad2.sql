DELIMITER //

CREATE PROCEDURE pokaz_na_litere(IN litera CHARACTER)
BEGIN

SELECT ImieAgenta, NazwiskoAgenta, DataZatrudnienia
FROM agenci
WHERE NazwiskoAgenta LIKE CONCAT(litera, '%');

END //

DELIMITER ;

--CALL pokaz_na_litere('K');

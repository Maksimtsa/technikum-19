DELIMITER //

CREATE PROCEDURE pokaz_rok(IN lat INT)
BEGIN

SELECT ImieAgenta, NazwiskoAgenta, DataZatrudnienia
FROM agenci
WHERE Year(now()) - YEAR(DataZatrudnienia) > lat;

END //

DELIMITER ;

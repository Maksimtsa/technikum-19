DELIMITER //
CREATE PROCEDURE moja_proc()

BEGIN
SELECT ImieAgenta, NazwiskoAgenta, DataZatrudnienia
FROM agenci;

END //

DELIMITER ;

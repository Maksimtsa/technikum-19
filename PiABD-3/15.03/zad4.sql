DELIMITER //

CREATE FUNCTION PodajSume()
RETURNS DOUBLE
BEGIN
    DECLARE suma DOUBLE;

    SELECT SUM(WartoscKontraktu)
    INTO suma
    FROM imprezy;
    RETURN suma;
END //

DELIMITER ;

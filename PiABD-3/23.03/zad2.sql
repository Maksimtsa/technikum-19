SELECT Wiek,
  CASE
    WHEN Wiek < 18 THEN 'nieletni'
    WHEN Wiek < 65 THEN 'dorosły'
    ELSE 'senior'
  END AS Kategoria
FROM mtab;

SELECT CONCAT('Zamówienie numer') as ZamówienieNumer, zamowienia.NumerZamowienia, SUM(produkty.CenaDetaliczna * dane_zamowien.ZamowionaIlosc) as WatośćZamówienia
FROM zamowienia
INNER JOIN dane_zamowien on zamowienia.NumerZamowienia = dane_zamowien.NumerZamowienia
INNER JOIN produkty on dane_zamowien.NumerProduktu = produkty.NumerProduktu
GROUP BY zamowienia.NumerZamowienia
ORDER BY zamowienia.NumerZamowienia

SELECT klienci.MiastoKlienta, SUM(produkty.CenaDetaliczna * dane_zamowien.ZamowionaIlosc) AS wartosc_zamowienia
FROM klienci
INNER JOIN zamowienia ON klienci.IDKlienta = zamowienia.IDKlienta
INNER JOIN dane_zamowien ON zamowienia.NumerZamowienia = dane_zamowien.NumerZamowienia
INNER JOIN produkty ON dane_zamowien.NumerProduktu = produkty.NumerProduktu
GROUP BY klienci.MiastoKlienta
ORDER BY klienci.MiastoKlienta ASC

SELECT zamowienia.NumerZamowienia, zamowienia.DataWysylki, zamowienia.DataZamowienia,
CASE
	WHEN zamowienia.DataWysylki IS null	THEN "nie wyslano"
    #WHEN DATEDIFF(zamowienia.DataWysylki, zamowienia.DataZamowienia) > 3 THEN 'opoznienie'
    WHEN zamowienia.DataWysylki > zamowienia.DataZamowienia + INTERVAL 3 day THEN "opoznienie"
    ELSE 'na czas'
END AS StatusWysylki
FROM zamowienia;

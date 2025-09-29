-- 1. Klienci
CREATE TABLE Klienci (
    KlientID INT PRIMARY KEY AUTO_INCREMENT,
    Imie VARCHAR(50),
    Nazwisko VARCHAR(50),
    DataUrodzenia DATE,
    Email VARCHAR(100),
    Telefon VARCHAR(20),
    AdresUlica VARCHAR(100),
    AdresMiasto VARCHAR(50),
    AdresKodPocztowy VARCHAR(10),
    DataOstatniejZmianyAdresu DATE
);

-- 2. Samochody
CREATE TABLE Samochody (
    SamochodID INT PRIMARY KEY AUTO_INCREMENT,
    KlientID INT,
    Marka VARCHAR(50),
    Model VARCHAR(50),
    RokProdukcji YEAR,
    NumerRejestracyjny VARCHAR(20),
    VIN VARCHAR(50),
    FOREIGN KEY (KlientID) REFERENCES Klienci(KlientID)
);

-- 3. Pracownicy
CREATE TABLE Pracownicy (
    PracownikID INT PRIMARY KEY AUTO_INCREMENT,
    Imie VARCHAR(50),
    Nazwisko VARCHAR(50),
    DataUrodzenia DATE,
    StanCywilny VARCHAR(20),
    Telefon VARCHAR(20),
    Email VARCHAR(100),
    DataZatrudnienia DATE,
    Stanowisko VARCHAR(50),
    CzyKobieta BOOLEAN,
    Uwagi TEXT
);

-- 4. Ubezpieczeni (dzieci i małżonkowie pracowników)
CREATE TABLE Ubezpieczeni (
    UbezpieczonyID INT PRIMARY KEY AUTO_INCREMENT,
    PracownikID INT,
    Imie VARCHAR(50),
    Nazwisko VARCHAR(50),
    RodzajUbezpieczenia ENUM('dziecko', 'malzonek'),
    DataUrodzenia DATE,
    FOREIGN KEY (PracownikID) REFERENCES Pracownicy(PracownikID)
);

-- 5. Dostawcy
CREATE TABLE Dostawcy (
    DostawcaID INT PRIMARY KEY AUTO_INCREMENT,
    NazwaFirmy VARCHAR(100),
    KontaktImie VARCHAR(50),
    KontaktNazwisko VARCHAR(50),
    Telefon VARCHAR(20),
    Email VARCHAR(100),
    AdresUlica VARCHAR(100),
    AdresMiasto VARCHAR(50),
    AdresKodPocztowy VARCHAR(10)
);

-- 6. Części_Zamienne
CREATE TABLE Czesc_Zamienna (
    CzescID INT PRIMARY KEY AUTO_INCREMENT,
    NazwaCzesci VARCHAR(100),
    Opis TEXT,
    IloscMagazyn INT,
    CenaZakupu DECIMAL(10,2),
    CenaSprzedazy DECIMAL(10,2),
    DostawcaID INT,
    FOREIGN KEY (DostawcaID) REFERENCES Dostawcy(DostawcaID)
);

-- 7. Naprawy
CREATE TABLE Naprawy (
    NaprawaID INT PRIMARY KEY AUTO_INCREMENT,
    SamochodID INT,
    PracownikID INT,
    DataNaprawy DATE,
    StanowiskoID INT,
    TypNaprawy VARCHAR(50),
    Status VARCHAR(20),
    FOREIGN KEY (SamochodID) REFERENCES Samochody(SamochodID),
    FOREIGN KEY (PracownikID) REFERENCES Pracownicy(PracownikID),
    FOREIGN KEY (StanowiskoID) REFERENCES Stanowiska_Naprawcze(StanowiskoID)
);

-- 8. Części_W_Naprawie (relacja wiele do wielu Naprawy <-> Części)
CREATE TABLE Czesc_W_Naprawie (
    NaprawaID INT,
    CzescID INT,
    IloscUzyta INT,
    PRIMARY KEY (NaprawaID, CzescID),
    FOREIGN KEY (NaprawaID) REFERENCES Naprawy(NaprawaID),
    FOREIGN KEY (CzescID) REFERENCES Czesc_Zamienna(CzescID)
);

-- 9. Faktury_Paragony
CREATE TABLE Faktury_Paragony (
    DokumentID INT PRIMARY KEY AUTO_INCREMENT,
    NaprawaID INT,
    TypDokumentu ENUM('faktura', 'paragon'),
    DataWystawienia DATE,
    KwotaNetto DECIMAL(10,2),
    KwotaVAT DECIMAL(10,2),
    KwotaBrutto DECIMAL(10,2),
    NumerDokumentu VARCHAR(50),
    FOREIGN KEY (NaprawaID) REFERENCES Naprawy(NaprawaID)
);

-- 10. Raporty_Kasowe
CREATE TABLE Raporty_Kasowe (
    RaportID INT PRIMARY KEY AUTO_INCREMENT,
    DataRaportu DATE UNIQUE,
    KwotaSprzedazyNetto DECIMAL(10,2),
    KwotaVAT DECIMAL(10,2),
    KwotaSprzedazyBrutto DECIMAL(10,2),
    Uwagi TEXT
);

-- 11. Czas_Pracy
CREATE TABLE Czas_Pracy (
    CzasPracyID INT PRIMARY KEY AUTO_INCREMENT,
    PracownikID INT,
    Data DATE,
    Zmiana ENUM('I', 'II'),
    GodzinaRozpoczecia TIME,
    GodzinaZakonczenia TIME,
    LiczbaGodzin DECIMAL(4,2),
    FOREIGN KEY (PracownikID) REFERENCES Pracownicy(PracownikID)
);

-- 12. Kampanie_Reklamowe
CREATE TABLE Kampanie_Reklamowe (
    KampaniaID INT PRIMARY KEY AUTO_INCREMENT,
    NazwaKampanii VARCHAR(100),
    TypKampanii ENUM('email', 'SMS'),
    DataRozpoczecia DATE,
    DataZakonczenia DATE,
    Opis TEXT
);

-- 13. Wysłane_Zaproszenia
CREATE TABLE Wyslane_Zaproszenia (
    ZaproszenieID INT PRIMARY KEY AUTO_INCREMENT,
    KampaniaID INT,
    KlientID INT,
    DataWyslania DATETIME,
    TypWiadomosci ENUM('email', 'SMS'),
    StatusWyslania ENUM('wyslano', 'blad'),
    FOREIGN KEY (KampaniaID) REFERENCES Kampanie_Reklamowe(KampaniaID),
    FOREIGN KEY (KlientID) REFERENCES Klienci(KlientID)
);

-- 14. Przeglądy_Techniczne
CREATE TABLE Przeglady_Techniczne (
    PrzegladID INT PRIMARY KEY AUTO_INCREMENT,
    SamochodID INT,
    DataPrzegladu DATE,
    WynikPrzegladu ENUM('pozytywny', 'negatywny'),
    Uwagi TEXT,
    FOREIGN KEY (SamochodID) REFERENCES Samochody(SamochodID)
);

-- 15. Stanowiska_Naprawcze
CREATE TABLE Stanowiska_Naprawcze (
    StanowiskoID INT PRIMARY KEY AUTO_INCREMENT,
    NazwaStanowiska VARCHAR(50),
    Opis TEXT
);

-- 16. Komputery
CREATE TABLE Komputery (
    KomputerID INT PRIMARY KEY AUTO_INCREMENT,
    NazwaKomputera VARCHAR(50),
    Lokalizacja VARCHAR(50),
    Opis TEXT
);

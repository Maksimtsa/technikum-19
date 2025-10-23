def czy_doskonala(liczba):
    suma = 0
    i = 1
    while i < liczba:
        if liczba % i == 0:
            suma += i
        i += 1
    return suma == liczba


liczba = 6
if czy_doskonala(liczba):
    print("TAK, liczba", liczba, "jest doskonała")
else:
    print("NIE, liczba", liczba, "nie jest doskonała")

#test
if czy_doskonala(28):
    print("Test OK (28 jest doskonała)")
else:
    print("Test BŁĄD")

if czy_doskonala(10):
    print("Test OK (10 nie jest doskonała)")
else:
    print("Test BŁĄD")

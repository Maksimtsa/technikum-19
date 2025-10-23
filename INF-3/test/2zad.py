def oblicz_bmi(masa, wzrost):
    return masa / (wzrost * wzrost)

def czy_moze_na_wizyte(wiek, bmi):
    if wiek <= 18:
        return "Pacjent za młody, NIE może na wizytę."
    elif 18.5 <= bmi <= 24.9:
        return "BMI prawidłowe, pacjent MOŻE na wizytę."
    else:
        return "BMI nieprawidłowe, pacjent NIE może na wizytę."


wiek = 25
masa = 70
wzrost = 1.75

bmi = oblicz_bmi(masa, wzrost)
print("BMI pacjenta:", bmi)
print(czy_moze_na_wizyte(wiek, bmi))


#test
wiek = 17
masa = 60
wzrost = 1.70
bmi = oblicz_bmi(masa, wzrost)
if wiek <= 18 or bmi < 18.5 or bmi > 24.9:
    print("Test OK (za młody lub złe BMI)")
else:
    print("Test BŁĄD")

wiek = 30
masa = 80
wzrost = 1.80
bmi = oblicz_bmi(masa, wzrost)
if wiek > 18 and 18.5 <= bmi <= 24.9:
    print("Test OK (BMI prawidłowe)")
else:
    print("Test BŁĄD (BMI poza zakresem)")

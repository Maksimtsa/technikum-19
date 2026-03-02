liczba = 123

#binarny
print(bin(liczba))
#szesnatskowy
#czy w liczbie jest symbol z alfabetu
hex_number = hex(liczba)
print(hex_number)
alfabet = "abcdefghijklmnopqrstuvwxyz"
for char in hex_number:
    if char in alfabet:
        print("ja ja")
else:
    print("na")

#osemkowy
print(oct(liczba))

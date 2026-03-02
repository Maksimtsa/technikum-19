def contHex(number):
    hex_str = hex(number)[2:]
    for char in hex_str:
        if char.isalpha():
            return "Tak"
    return "Nie"

# print(ifHex(123))

with open("PARY_LICZB.TXT", 'r') as file:
    dane = [list(map(int, line.split())) for line in file.read().splitlines()]

# zad 1
counter1 = 0
for i in dane:
    a, b = i #i[0], i[1]
    if b % a == 0 or a % b == 0:
        counter1 += 1

print(counter1)


# zad 2
def nwd(a, b):
    while b != 0:
        a, b = b, a % b
    return a


counter2 = 0
for i in dane:
    a, b = i
    if nwd(a, b) == 1:
        counter2 += 1
print(counter2)

# zad 3

def suma_cyfr(a:str)->int: #a -> string
    suma = 0
    for i in a:
        suma += int(i)
    return suma

counter3 = 0
for i in dane:
    a, b = i
    if suma_cyfr(a) == suma_cyfr(b):
        counter3 += 1


with open("Zadania5.txt", 'a') as file:
    file.write(f"Zad a: {counter1}, Zad b: {counter2}, Zad c: {counter3}")

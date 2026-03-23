with open("PARY_LICZB.TXT") as file:
    dane = [list(map(int, line.split())) for line in file.read().splitlines()]


counter = 0
for i in dane:
    a, b = i #i[0], i[1]
    if b % a == 0 or a % b == 0:
        counter += 1

print(counter)



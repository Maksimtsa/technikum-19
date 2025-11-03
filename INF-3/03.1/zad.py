with open("napisy.txt", 'r') as file:
    numbers = file.read().split()

#zad a)
count = 0
for number in numbers:
    if len(number) % 2 == 0:
        count += 1

with open("zadanie4.txt", 'a') as file:
    file.write(f"zadanie a)\n{count}\n")

#zad b)
counter = 0
for i in numbers:
    if i.count("0") == i.count("1"):
        counter+=1
with open("zadanie4.txt", 'a') as file:
    file.write(f"zadanie b)\n{counter}\n")


#zad c)
count0 = 0
count1 = 0

for i in numbers:
    if i.count("0") == 0:
        count0 += 1
    if i.count("1") == 0:
        count1 += 1
with open("zadanie4.txt", 'a') as file:
    file.write(f"zadanie c)\n{count0} {count1}\n")

#zad d)
ddd = dict()
for strin in numbers:
    dd = False
    i = 2
    while dd == False:
        while i <= 16:
            if len(strin) == i:
                if not ddd.get(f'{i}'):
                    num = 0
                else:
                    num = ddd.get(f'{i}')
                num = int(num)
                num += 1
                ddd.update({f'{i}': f'{num}'})
                dd = True
            i += 1

for j in range(15):
    j += 2
    il = ddd.get(f'{j}')
    print(f'długość: {j}, ilość: {il}')

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
count1 = 0
count0 = 0
if numbers == 0:
    count0 += 1

len = len(numbers)
for i in numbers:
    sum += 1
if len == sum:
    count1 += 1

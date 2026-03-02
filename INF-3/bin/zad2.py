with open("liczba.txt", "r") as file:
    #numbers = [int(i) for i in file.readline().split("")]
    numbers = list(map(int, file.read().split()))

print(numbers)

with open("liczba.txt", "a") as file:
    for number in numbers:
        file.write(f"{bin(number)[2:]}\n")


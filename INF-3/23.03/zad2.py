counter = 0
def F(x):
    global counter
    counter += 1
    if x == 0:
        return 0
    else:

        return 2 + F(x//2)

print(F(3))
print(counter)

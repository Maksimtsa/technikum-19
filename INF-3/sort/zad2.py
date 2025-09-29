def sito(n):
    t = [True] * (n + 1)
    t[0] = t[1] = False
    p = int(n ** (1 / 2))
    for i in range(2, p + 1):
        if t[i]:
            for j in range(i * i, n + 1, i):
                t[j] = False
    return t

A, B = map(int, input().split())
t = sito(B)
pierwsze = []

for i in range(A, B + 1):
    if t[i]:
        pierwsze.append(str(i))

if pierwsze:
    print(" ".join(pierwsze))
else:
    print("BRAK")

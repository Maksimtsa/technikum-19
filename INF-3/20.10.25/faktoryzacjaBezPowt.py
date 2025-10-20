def czynnikiPierwsze(n):
    divisior = 2
    t = []
    while n > 1:
        if n % divisior == 0:
            n //= divisior
            t.append(divisior)
        else:
            divisior += 1
    return set(t)
print(czynnikiPierwsze(1000))

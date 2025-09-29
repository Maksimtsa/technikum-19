def is_prime(x):
    if x < 2:
        print("NIE")
        return
    if x == 2:
        print("TAK")
        return
    if x % 2 == 0:
        print("NIE")
        return
    p = int(x**(1/2))
    for i in range(3, p+1,2):
        if x % i == 0:
            print("NIE")
            return
    print("TAK")
    return


x = int(input())
is_prime(x)

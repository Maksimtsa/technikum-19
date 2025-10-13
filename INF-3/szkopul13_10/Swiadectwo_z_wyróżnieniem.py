for _ in range(3):
    n = int(input())
    grades = list(map(int, input().split()))
    avg = sum(grades) / n
    if avg >= 4.75:
        print("TAK")
    else:
        print("NIE")

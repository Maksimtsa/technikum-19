n = int(input())
t = list(map(int, input().split()))

counts = [0] * 7
for grade in t:
    counts[grade] += 1

print(counts[1], counts[2], counts[3], counts[4], counts[5], counts[6])

def merge_sort(t, tmp, p, k):
    if p < k:
        sr = (p + k) // 2
        merge_sort(t, tmp, p, sr)
        merge_sort(t, tmp, sr + 1, k)
        i1 = p
        i2 = sr + 1

        for i in range(p, k + 1):
            if i1 > sr or (i2 <= k and t[i2] < t[i1]):
                tmp[i] = t[i2]
                i2 += 1
            else:
                tmp[i] = t[i1]
                i1 += 1

        for i in range(p, k + 1):
            t[i] = tmp[i]

t = [5, 2, 6, 10, 14, 8, 1]
tmp = [0] * len(t)
merge_sort(t, tmp, 0, len(t) - 1)
print(t)

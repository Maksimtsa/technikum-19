from random import randint
t = [randint(1, 10) for i in range(50)]
print(t)
maxi = t[0]
for i in range(len(t)):
    if t[i] > maxi:
        maxi = t[i]
print("max wartosc" , maxi)
tp = [0] * (maxi + 1)
print (tp)
for i in range (len(t)):
    tp[t[i]] +=1
print (tp)
for i in range (len(t)):
    if tp[i]:
        for j in range(tp[i]):
            print(i, end = " ")
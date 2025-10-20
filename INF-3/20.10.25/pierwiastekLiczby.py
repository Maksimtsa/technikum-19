import math 
def sqrt(x, eps): 
    a = 0 
    b = x 
    while abs(a-b) > eps: 
        c = (a+b)/2 
        if c*c > x: 
            b = c 
        else: 
            a = c 
    return c

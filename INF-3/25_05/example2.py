def substr_sum(array, actual):
    left = 0
    actual_sum = 0

    for right in range(len(array)):
        actual_sum += array[right]
        while actual_sum > actual and left <= right:
            actual_sum -= array[left]
            left += 1
        if actual_sum == actual:
            return array[left:right+1]

    return []

result = substr_sum([1, 2, 3, 4, 5, 6, 7, 8, 9], 6)
print(result)

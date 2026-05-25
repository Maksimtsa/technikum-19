def substr_sum(arr, actual):
    left = 0
    right = 0
    current_sum = 0
    while right < len(arr):
        current_sum += arr[right]
        right += 1

        while current_sum > actual:
            current_sum -= arr[left]
            left += 1

        if current_sum == actual:
            return arr[left:right]

    return []

result = substr_sum([1, 2, 3, 4, 5, 6, 7, 8, 9], 9)
print(result)

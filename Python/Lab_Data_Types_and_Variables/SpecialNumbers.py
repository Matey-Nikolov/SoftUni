n = int(input())

for num in range(1, n +1):

    sumOfDigits = 0
    digits = num

    while digits > 0:
        sumOfDigits += digits % 10
        digits = int(digits / 10)

    if sumOfDigits == 5 or sumOfDigits == 7 or sumOfDigits == 11:
        print(f'{num} -> True')
    else:
        print(f'{num} -> False')
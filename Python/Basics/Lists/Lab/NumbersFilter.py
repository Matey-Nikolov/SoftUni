n = int(input())

numbers = []
filtered = []

for i in range(n):
    currentNumber = int(input())
    numbers.append(currentNumber)

filterWord = input()

if filterWord == "even":
    for i in numbers:
        if i % 2 == 0:
            filtered.append(i)
elif filterWord == "odd":
    for i in numbers:
        if i % 2 != 0:
            filtered.append(i)
elif filterWord == "negative":
    for i in numbers:
        if i < 0:
            filtered.append(i)
elif filterWord == "positive":
    for i in numbers:
        if i >= 0:
            filtered.append(i)

print(filtered)
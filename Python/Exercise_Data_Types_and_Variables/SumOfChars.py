n = int(input())

if n >= 20:
    n = 20

sum = 0
for i in range(n):
    charInput = input()
    sum += ord(charInput)

print(f'The sum equals: {sum}')
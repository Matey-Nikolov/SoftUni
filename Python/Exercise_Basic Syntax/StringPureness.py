n = int(input())

for i in range(n):
    inputString = input()

    result = inputString.find('.', ',', '_')
    if result > 0:
        print(f"{inputString} is not pure!")
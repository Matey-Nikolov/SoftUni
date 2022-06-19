numberN = int(input())

for i in range(0, numberN):
    for k in range(0, numberN):
        for j in range(0, numberN):
            print(f"{chr(97 + i)}{chr(97 + k)}{chr(97 + j)}")
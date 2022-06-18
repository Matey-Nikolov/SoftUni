numberOfNLitersOfWater = int(input())

waterTank = 0

for i in range(numberOfNLitersOfWater):

    litersOfWater = int(input())

    if (litersOfWater + waterTank <= 255) and waterTank != 255:
        waterTank += litersOfWater
    else:
        print('Insufficient capacity!')

print(waterTank)
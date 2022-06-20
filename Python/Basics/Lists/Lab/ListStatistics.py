"""
n = int(input())

countOfPositivesNumbers = 0
SumNegativesNumbers = 0

numbersListPositives = []
numbersListNegatives = []

for i in range(n):
    number = int(input())

    if number >= 0:
        countOfPositivesNumbers += 1
        numbersListPositives.append(number)
    else:
        SumNegativesNumbers += number
        numbersListNegatives.append(number)

print(numbersListPositives)
print(numbersListNegatives)
print(f'Count of positives: {countOfPositivesNumbers}')
print(f'Sum of negatives: {SumNegativesNumbers}')
"""

n = int(input())

positiveNumbers = []
negativeNumbers = []

for i in range(n):
    number = int(input())
    
    if number >= 0:
        positiveNumbers.append(number)
    else:
        negativeNumbers.append(number)

print(positiveNumbers)
print(negativeNumbers)
print(f"Count of positives: {len(positiveNumbers)}")
print(f"Sum of negatives: {sum(negativeNumbers)}")
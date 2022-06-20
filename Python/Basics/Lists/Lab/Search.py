n = int(input())
filterWord = input()

listOfString = []

for i in range(n):
    currentInput = input()
    listOfString.append(currentInput)

print(listOfString)

for i in range(len(listOfString) - 1, -1 , -1):
    element = listOfString[i]

    if filterWord not in element:
        listOfString.remove(element)

print(listOfString)
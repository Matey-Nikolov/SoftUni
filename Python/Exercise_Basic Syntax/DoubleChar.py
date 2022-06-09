inputText = input()

while inputText != "End":

    if inputText == "SoftUni":
        inputText = input()
        continue

    listText = [] 

    for k in inputText:
        listText.append(k)

    totalResult = ""

    for i in range(len(inputText)):
        result = inputText[i] + listText[i]
        totalResult += result
        
    print(totalResult)

    inputText = input()
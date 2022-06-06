firstNumber = input()
secondNumber = input()
thirdNumber = input()

if firstNumber > secondNumber and firstNumber > thirdNumber:
    print(firstNumber)
elif secondNumber > firstNumber and secondNumber > thirdNumber:
    print(secondNumber)
else:
    print(thirdNumber)
budget = int(input())
command = input()

while command != "End":
    productPrice = int(command)
    budget -= productPrice
    if budget < 0:
        print("You went is overdraft!")
        break

    command = input()
else:
    print("You bought everything needed.")
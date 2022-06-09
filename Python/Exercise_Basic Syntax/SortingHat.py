inputNameOrWelcome = input()
count = 0

while inputNameOrWelcome != "Welcome!":


    if inputNameOrWelcome == "Voldemort":
        print("You must not speak of that name!")
        count += 1
        break

    lengthName = len(inputNameOrWelcome)

    if  lengthName < 5:
        print(f"{inputNameOrWelcome} goes to Gryffindor.")
    elif lengthName == 5:
        print(f"{inputNameOrWelcome} goes to Slytherin.")
    elif lengthName == 6:
        print(f"{inputNameOrWelcome} goes to Ravenclaw.")
    elif lengthName > 6:
        print(f"{inputNameOrWelcome} goes to Hufflepuff.")

    inputNameOrWelcome = input()

if count != 1:
    print("Welcome to Hogwarts.")
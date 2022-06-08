numberOfOrders = int(input())
total = 0

for i in range(numberOfOrders):
    pricePerCapsule = float(input())
    days = int(input())
    capsulesNeedPerDay = int(input())

    coffePrice = pricePerCapsule * days * capsulesNeedPerDay
    total += coffePrice
    print(f"The price for the coffee is: ${coffePrice:.2f}")

print(f"Total: ${total:.2f}")
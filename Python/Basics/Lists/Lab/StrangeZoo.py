tail = input()
body = input()
head = input()

arrangeList = [tail, body, head]

arrangeList[0], arrangeList[2] = arrangeList[2], arrangeList[0]
print(arrangeList)
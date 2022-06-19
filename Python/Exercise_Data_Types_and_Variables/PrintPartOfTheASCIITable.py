startNumberIndex = int(input())
endNumberIndex = int(input())

result = ''

for i in range(startNumberIndex, endNumberIndex):
    result += chr(startNumberIndex) + ' '
    startNumberIndex += 1



result += chr(startNumberIndex)

print(result)